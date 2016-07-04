using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Trencadis.Tools.TextTransformations.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectTransformationsFile_Click(object sender, EventArgs e)
        {
            if (dlgOpenTransformationsFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTransformationsFilePath.Text = dlgOpenTransformationsFile.FileName;

                var transformDefs = File.ReadAllText(dlgOpenTransformationsFile.FileName);

                txtTransformationsDefinitionsContent.Text = transformDefs;
            }
        }

        private void btnSelectInputFile_Click(object sender, EventArgs e)
        {
            if (dlgOpenInputFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtInputFilePath.Text = dlgOpenInputFile.FileName;

                var inputContent = File.ReadAllText(dlgOpenInputFile.FileName);

                txtInputContent.Text = inputContent;
            }
        }

        private void btnApplyTransformations_Click(object sender, EventArgs e)
        {
            var transformationsDefinition = txtTransformationsDefinitionsContent.Text;

            if (string.IsNullOrWhiteSpace(transformationsDefinition))
            {
                MessageBox.Show("No transformation definitions found");
                return;
            }

            if (!IsXmlContent(transformationsDefinition))
            {
                MessageBox.Show("Transformation definitions must form a valid XML document / document fragment ");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInputContent.Text))
            {
                MessageBox.Show("No input found");
                return;
            }

            var transformations = TextTransformationsFacade.CreateFromXmlContent(txtTransformationsDefinitionsContent.Text);

            var transformedInput = TextTransformationsRunner.RunTransformations(txtInputContent.Text, transformations);

            txtResults.Text = transformedInput;
        }

        private bool IsXmlContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                return false;
            }

            if (!content.StartsWith("<"))
            {
                return false;
            }

            if (!content.EndsWith(">"))
            {
                return false;
            }

            try
            {
                var xml = XElement.Parse(content);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnSaveResultsBackToFile_Click(object sender, EventArgs e)
        {
            var originalInputFile = txtInputFilePath.Text;
            if (string.IsNullOrWhiteSpace(originalInputFile))
            {
                MessageBox.Show("No input file selected");
                return;
            }

            if (!File.Exists(originalInputFile))
            {
                MessageBox.Show("The specified input file doesn't exist");
                return;
            }

            var confirmResult = MessageBox.Show("This will overwrite the original input file, confirm", "Confirm file overwrite", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                File.WriteAllText(originalInputFile, txtResults.Text);
            }
        }
    }
}
