using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;


namespace FindItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_GotFocus(Object sender, EventArgs e)
        {
            try
            {
                mshtml.HTMLDocument document = (mshtml.HTMLDocument)webBrowser1.Document.DomDocument;// as mshtml.HTMLDocument;
                HTMLSelectElement categiries = (HTMLSelectElement)document.getElementById("gh-cat");
                foreach (HTMLOptionElement elem in categiries)
                {
                    comboBox1.Items.Add(elem.innerText);
                }
            }
            catch { }
        }
        private void comboBox2_GotFocus(Object sender, EventArgs e)
        {
            try
            {
                mshtml.HTMLDocument document = (mshtml.HTMLDocument)webBrowser2.Document.DomDocument;// as mshtml.HTMLDocument;
                HTMLSelectElement categiries = (HTMLSelectElement)document.getElementById("searchDropdownBox");
                foreach (HTMLOptionElement elem in categiries)
                {
                    comboBox2.Items.Add(elem.innerText);
                }
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mshtml.HTMLDocument document = (mshtml.HTMLDocument)webBrowser1.Document.DomDocument;// as mshtml.HTMLDocument;
                HTMLSelectElement categiries = (HTMLSelectElement)document.getElementById("gh-cat");
                foreach (HTMLOptionElement elem in categiries)
                {
                    if (comboBox1.Text.Equals(elem.innerText))
                    {
                        HTMLSelectElement hField1 = (HTMLSelectElement)document.getElementById("gh-cat");
                        hField1.setAttribute("value", elem.value);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mshtml.HTMLDocument document = (mshtml.HTMLDocument)webBrowser2.Document.DomDocument;// as mshtml.HTMLDocument;
                HTMLSelectElement categiries = (HTMLSelectElement)document.getElementById("searchDropdownBox");
                foreach (HTMLOptionElement elem in categiries)
                {
                    if (comboBox2.Text.Equals(elem.innerText))
                    {
                        HTMLSelectElement hField1 = (HTMLSelectElement)document.getElementById("searchDropdownBox");
                        hField1.setAttribute("value", elem.value);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                mshtml.HTMLDocument document = (mshtml.HTMLDocument)webBrowser2.Document.DomDocument;
                HTMLInputElement search = (HTMLInputElement)document.getElementById("twotabsearchtextbox");
                search.setAttribute("value",txtBoxSearchItem.Text);
                //TODO
                //Find Javascript and invokescript CLICK
                listItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listItems()
        {
            try
            {
                mshtml.HTMLDocument document = (mshtml.HTMLDocument)webBrowser2.Document.DomDocument;
                HTMLDivElement searchResultItems = (HTMLDivElement)document.getElementById("atfResults");

                
                

                foreach (HTMLLIElement child in searchResultItems.firstChild.childNodes)
                {
                    Items item = new Items();
                    var temp = child.firstChild;

                    for (int i = 0; i < 7; i++)
                    {
                        temp = temp.firstChild;
                        //TODO 
                        //To get the 7th node and export the info from it.
                        MessageBox.Show(temp.attributes);
                    }
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
