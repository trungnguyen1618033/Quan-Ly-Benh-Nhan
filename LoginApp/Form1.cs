using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            # region default values of rtxtText
            rtxtText.Text = "Hello";
            rtxtText.SelectAll();
            rtxtText.SelectionAlignment = HorizontalAlignment.Center;
            #endregion

            #region default values for cboSize
            cboSize.Items.Add(8);
            cboSize.Items.Add(9);
            cboSize.Items.Add(10);
            cboSize.Items.Add(11);
            cboSize.Items.Add(12);
            cboSize.Items.Add(14);
            cboSize.Items.Add(16);
            cboSize.Items.Add(18);
            cboSize.Items.Add(20);
            cboSize.Items.Add(22);
            cboSize.Items.Add(24);
            cboSize.Items.Add(26);
            cboSize.Items.Add(28);
            cboSize.Items.Add(36);
            cboSize.Items.Add(48);
            cboSize.Items.Add(72);
            #endregion

            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                cboFont.Items.Add(oneFontFamily.Name);
            }
        }


        private void pnColor_MouseClick(object sender, MouseEventArgs e)
        {
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                pnColor.BackColor = cdColor.Color;
                rtxtText.SelectAll();
                rtxtText.SelectionColor = cdColor.Color;
            }
                
        }        

        #region Text style (B, I, U_)
        private void chkB_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkB.Checked)
            {
                Font new1, old1;
                old1 = rtxtText.SelectionFont;
                if (old1.Bold)
                    new1 = new Font(old1, old1.Style & ~FontStyle.Bold);
                else
                    new1 = new Font(old1, old1.Style | FontStyle.Bold);

                rtxtText.SelectionFont = new1;
            }
            else
            {
                if (!chkI.Checked && !chkU.Checked)
                {
                    Font currentFont = rtxtText.SelectionFont;
                    FontStyle newFontStyle = (FontStyle)(currentFont.Style);
                    rtxtText.SelectionFont = new Font(currentFont, FontStyle.Regular);
                }
                   
                else if (!chkU.Checked && chkI.Checked)
                {
                    Font currentFont = rtxtText.SelectionFont;
                    FontStyle newFontStyle = (FontStyle)(currentFont.Style);
                    rtxtText.SelectionFont = new Font(currentFont, FontStyle.Italic);
                }
                    
                else if (chkU.Checked && !chkI.Checked)
                {
                    Font currentFont = rtxtText.SelectionFont;
                    FontStyle newFontStyle = (FontStyle)(currentFont.Style);
                    rtxtText.SelectionFont = new Font(currentFont, FontStyle.Underline);
                }
                    
                else
                {
                    Font currentFont = rtxtText.SelectionFont;
                    FontStyle newFontStyle = (FontStyle)(currentFont.Style);
                    rtxtText.SelectionFont = new Font(currentFont, FontStyle.Italic);

                    Font new1, old1;
                    old1 = rtxtText.SelectionFont;
                    if (old1.Underline)
                        new1 = new Font(old1, old1.Style & ~FontStyle.Underline);
                    else
                        new1 = new Font(old1, old1.Style | FontStyle.Underline);

                    rtxtText.SelectionFont = new1;
                }
            }
        }

        private void chkI_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkI.Checked)
            {
                Font new1, old1;
                old1 = rtxtText.SelectionFont;
                if (old1.Italic)
                    new1 = new Font(old1, old1.Style & ~FontStyle.Italic);
                else
                    new1 = new Font(old1, old1.Style | FontStyle.Italic);

                rtxtText.SelectionFont = new1;
            }
            else
            {
                if (!chkB.Checked && !chkU.Checked)
                {
                    Font currentFont = rtxtText.SelectionFont;
                    FontStyle newFontStyle = (FontStyle)(currentFont.Style);
                    rtxtText.SelectionFont = new Font(currentFont, FontStyle.Regular);
                }
                    
                else if (!chkU.Checked && chkB.Checked)
                {
                    Font currentFont = rtxtText.SelectionFont;
                    FontStyle newFontStyle = (FontStyle)(currentFont.Style);
                    rtxtText.SelectionFont = new Font(currentFont, FontStyle.Bold);
                }
                    
                else if (chkU.Checked && !chkB.Checked)
                {
                    Font currentFont = rtxtText.SelectionFont;
                    FontStyle newFontStyle = (FontStyle)(currentFont.Style);
                    rtxtText.SelectionFont = new Font(currentFont, FontStyle.Underline);
                }                    
                else
                {
                    Font currentFont = rtxtText.SelectionFont;
                    FontStyle newFontStyle = (FontStyle)(currentFont.Style);
                    rtxtText.SelectionFont = new Font(currentFont, FontStyle.Bold);

                    Font new1, old1;
                    old1 = rtxtText.SelectionFont;
                    if (old1.Underline)
                        new1 = new Font(old1, old1.Style & ~FontStyle.Underline);
                    else
                        new1 = new Font(old1, old1.Style | FontStyle.Underline);

                    rtxtText.SelectionFont = new1;
                }
            }
        }

        private void chkU_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkU.Checked)
            {
                Font new1, old1;
                old1 = rtxtText.SelectionFont;
                if (old1.Underline)
                    new1 = new Font(old1, old1.Style & ~FontStyle.Underline);
                else
                    new1 = new Font(old1, old1.Style | FontStyle.Underline);

                rtxtText.SelectionFont = new1;
            }
            else
            {
                if (!chkB.Checked && !chkI.Checked)
                {
                    Font currentFont = rtxtText.SelectionFont;
                    FontStyle newFontStyle = (FontStyle)(currentFont.Style);
                    rtxtText.SelectionFont = new Font(currentFont, FontStyle.Regular);
                }
                    
                else if (!chkI.Checked && chkB.Checked)
                {
                    Font currentFont = rtxtText.SelectionFont;
                    FontStyle newFontStyle = (FontStyle)(currentFont.Style);
                    rtxtText.SelectionFont = new Font(currentFont, FontStyle.Bold);
                }
                    
                else if (chkI.Checked && !chkB.Checked)
                {
                    Font currentFont = rtxtText.SelectionFont;
                    FontStyle newFontStyle = (FontStyle)(currentFont.Style);
                    rtxtText.SelectionFont = new Font(currentFont, FontStyle.Italic);
                }                    
                else
                {
                    Font currentFont = rtxtText.SelectionFont;
                    FontStyle newFontStyle = (FontStyle)(currentFont.Style);
                    rtxtText.SelectionFont = new Font(currentFont, FontStyle.Bold);

                    Font new1, old1;
                    old1 = rtxtText.SelectionFont;
                    if (old1.Italic)
                        new1 = new Font(old1, old1.Style & ~FontStyle.Italic);
                    else
                        new1 = new Font(old1, old1.Style | FontStyle.Italic);

                    rtxtText.SelectionFont = new1;
                }
            }
        }

        #endregion
        
        #region Alignment
        private void rdoLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLeft.Checked)
            {
                rtxtText.SelectAll();
                rtxtText.SelectionAlignment = HorizontalAlignment.Left;
            }
                
        }

        private void rdoCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCenter.Checked)
            {
                rtxtText.SelectAll();
                rtxtText.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void rdoRight_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRight.Checked)
            {
                rtxtText.SelectAll();
                rtxtText.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        #endregion

        private void cboSize_TextChanged(object sender, EventArgs e)
        {
            rtxtText.SelectAll();
            Font currentFont = rtxtText.SelectionFont;
            FontStyle newFontStyle = (FontStyle)(currentFont.Style);
            rtxtText.SelectionFont = new Font(currentFont.FontFamily, float.Parse(cboSize.Text), newFontStyle);            
        }

        private void cboFont_TextChanged(object sender, EventArgs e)
        {
            rtxtText.SelectAll();
            Font currentFont = rtxtText.SelectionFont;
            FontFamily newFontFamily = new FontFamily(cboFont.Text);
            FontStyle newFontStyle = (FontStyle)(currentFont.Style);
            float size = rtxtText.SelectionFont.Size;
            rtxtText.Font = new Font(newFontFamily, size, newFontStyle);
        }
    }
}
