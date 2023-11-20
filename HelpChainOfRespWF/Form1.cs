using HelpChainOfRespWF.Entities;
using HelpChainOfRespWF.Handler;

namespace HelpChainOfRespWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowHelpDisp(string Component)
        {
            IHelpDispHandler helpDispHandler = new HelpDispComponents.ButtonHelpDisp();
            helpDispHandler.SetNext(new HelpDispComponents.LabelHelpDisp())
                            .SetNext(new HelpDispComponents.TextBoxHelpDisp())
                            .SetNext(new HelpDispComponents.CheckBoxHelpDisp())
                            .SetNext(new HelpDispComponents.RadioButtonHelpDisp())
                            .SetNext(new HelpDispComponents.ComboBoxHelpDisp())
                            .SetNext(new HelpDispComponents.ListBoxHelpDisp())
                            .SetNext(new HelpDispComponents.GroupBoxHelpDisp())
                            .SetNext(new HelpDispComponents.DefaultHelpDisp());

            HelpDisp helpDisp = new HelpDisp(Component);
            helpDispHandler.ShowHelpInfo(helpDisp);

            if (helpDisp.Information != "")
                MessageBox.Show(helpDisp.Information, helpDisp.Component);
        }

        private void picLabelHelp_Click(object sender, EventArgs e)
        {
            ShowHelpDisp("Label");
        }

        private void picTextBoxHelp_Click_1(object sender, EventArgs e)
        {
            ShowHelpDisp("TextBox");
        }

        private void picButtonHelp_Click(object sender, EventArgs e)
        {
            ShowHelpDisp("Button");
        }

        private void picCheckBoxHelp_Click(object sender, EventArgs e)
        {
            ShowHelpDisp("CheckBox");
        }

        private void picRadioButtonHelp_Click(object sender, EventArgs e)
        {
            ShowHelpDisp("RadioButton");
        }

        private void picComboBoxHelp_Click(object sender, EventArgs e)
        {
            ShowHelpDisp("ComboBox");
        }

        private void picListBoxHelp_Click(object sender, EventArgs e)
        {
            ShowHelpDisp("ListBox");
        }

        private void picGroupBoxHelp_Click(object sender, EventArgs e)
        {
            ShowHelpDisp("GroupBox");
        }
    }
}