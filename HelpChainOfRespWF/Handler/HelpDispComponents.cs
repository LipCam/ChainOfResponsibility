using HelpChainOfRespWF.Entities;

namespace HelpChainOfRespWF.Handler
{
    public class HelpDispComponents
    {
        public class ButtonHelpDisp : HelpDispHandler
        {
            public override void ShowHelpInfo(HelpDisp helpDisp)
            {
                if (helpDisp.Component == "Button")
                {
                    helpDisp.Information = "Um botão de comando em um formulário pode iniciar uma ação ou um conjunto de ações.\n" +
                                        "Você poderia, por exemplo, crie um botão de comando que abre outro formulário. \n" +
                                        "Para tornar um botão de comando fizer alguma coisa, você pode escrever um macro ou procedimento de evento " +
                                        "e anexá-lo a do botão OnClick propriedade.";
                }
                else
                    base.ShowHelpInfo(helpDisp);
            }
        }

        public class LabelHelpDisp : HelpDispHandler
        {
            public override void ShowHelpInfo(HelpDisp helpDisp)
            {
                if (helpDisp.Component == "Label")
                {
                    helpDisp.Information = "Labels são usados para exibir texto que não pode ser editado pelo usuário.\n" +
                                            "Eles são usados para identificar objetos em um formulário e para fornecer uma descrição do que um determinado controle representa ou faz.";
                }
                else
                    base.ShowHelpInfo(helpDisp);
            }
        }

        public class TextBoxHelpDisp : HelpDispHandler
        {
            public override void ShowHelpInfo(HelpDisp helpDisp)
            {
                if (helpDisp.Component == "TextBox")
                {
                    helpDisp.Information = "Uma TextBox é o controle mais comumente usado para exibir informações digitadas por um usuário.";
                }
                else
                    base.ShowHelpInfo(helpDisp);
            }
        }

        public class CheckBoxHelpDisp : HelpDispHandler
        {
            public override void ShowHelpInfo(HelpDisp helpDisp)
            {
                if (helpDisp.Component == "CheckBox")
                {
                    helpDisp.Information = "Um CheckBox corresponde a uma caixa de seleção em um formulário ou relatório. \n" +
                                            "Essa caixa de seleção é um controle autônomo que exibe um valor Sim/Não de uma fonte do registro base.";
                }
                else
                    base.ShowHelpInfo(helpDisp);
            }
        }

        public class RadioButtonHelpDisp : HelpDispHandler
        {
            public override void ShowHelpInfo(HelpDisp helpDisp)
            {
                if (helpDisp.Component == "RadioButton")
                {
                    helpDisp.Information = "Um RadioButton permite que o usuário selecione uma única opção de um grupo de opções quando emparelhado com outros controles RadioButton.";
                }
                else
                    base.ShowHelpInfo(helpDisp);
            }
        }

        public class ComboBoxHelpDisp : HelpDispHandler
        {
            public override void ShowHelpInfo(HelpDisp helpDisp)
            {
                if (helpDisp.Component == "ComboBox")
                {
                    helpDisp.Information = "Um ComboBox corresponde a um controle de caixa de combinação.\n" +
                                            "O controle da caixa de combinação combina os recursos de uma caixa de texto e de uma caixa de listagem.\n" +
                                            "Use uma caixa de combinação quando quiser ter a opção de digitar um valor ou de selecionar um valor de uma lista predefinida.";
                }
                else
                    base.ShowHelpInfo(helpDisp);
            }
        }

        public class ListBoxHelpDisp : HelpDispHandler
        {
            public override void ShowHelpInfo(HelpDisp helpDisp)
            {
                if (helpDisp.Component == "ListBox")
                {
                    helpDisp.Information = "Um ListBox corresponde a um controle de caixa de listagem.\n" +
                                            "Controle de caixa de listagem exibe uma lista de valores ou alternativas.";
                }
                else
                    base.ShowHelpInfo(helpDisp);
            }
        }

        public class GroupBoxHelpDisp : HelpDispHandler
        {
            public override void ShowHelpInfo(HelpDisp helpDisp)
            {
                if (helpDisp.Component == "GroupBox")
                {
                    helpDisp.Information = "Os GroupBox são usados para agrupar outros controles.\n" +
                                            "Há três razões para agrupar controles:\r\n" +
                                            "\r\nPara criar um agrupamento visual dos elementos de formulário relacionados para uma interface do usuário clara.\r\n" +
                                            "\r\nPara criar um agrupamento programático (de botões de opção, por exemplo).\r\n" +
                                            "\r\nPara mover os controles como uma unidade em tempo de design.";
                }
                else
                    base.ShowHelpInfo(helpDisp);
            }
        }

        public class DefaultHelpDisp : HelpDispHandler
        {
            public override void ShowHelpInfo(HelpDisp helpDisp)
            {
                helpDisp.Information = "";
            }
        }
    }
}
