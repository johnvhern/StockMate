using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMate.Helpers
{
    public static class ButtonStyle
    {
        public static void TabButton(SfButton button)
        {
            // Button Border

            button.Style.Border = null;
            button.Style.FocusedBorder = null;
            button.Style.HoverBorder = null;
            button.Style.PressedBorder = null;

            // Button BackColor

            button.Style.BackColor = Color.FromArgb(243, 244, 246);
            button.Style.PressedBackColor = Color.White;
            button.Style.HoverBackColor = Color.White;
            button.Style.FocusedBackColor = Color.White;

            // Button ForeColor

            button.Style.ForeColor = Color.FromArgb(107, 114, 128);
            button.Style.FocusedForeColor = Color.FromArgb(43, 48, 59);
            button.Style.HoverForeColor = Color.FromArgb(43, 48, 59);
            button.Style.PressedForeColor = Color.FromArgb(43, 48, 59);

            // Button Image Color

            button.Style.ImageForeColor = Color.FromArgb(107, 114, 128);
            button.Style.FocusedImageForeColor = Color.FromArgb(43, 48, 59);
            button.Style.HoverImageForeColor = Color.FromArgb(43, 48, 59);
            button.Style.PressedImageForeColor = Color.FromArgb(43, 48, 59);
        }

        public static void ChildButton(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // Check if the control is an SfButton
                if (control is SfButton button)
                {
                    // Button Border

                    button.Style.Border = null;
                    button.Style.FocusedBorder = new Pen(Color.Gainsboro);
                    button.Style.HoverBorder = new Pen(Color.Gainsboro);
                    button.Style.PressedBorder = new Pen(Color.Gainsboro);

                    // Button BackColor

                    button.Style.BackColor = Color.FromArgb(243, 244, 246);
                    button.Style.PressedBackColor = Color.White;
                    button.Style.HoverBackColor = Color.White;
                    button.Style.FocusedBackColor = Color.White;

                    // Button ForeColor

                    button.Style.ForeColor = Color.FromArgb(107, 114, 128);
                    button.Style.FocusedForeColor = Color.FromArgb(43, 48, 59);
                    button.Style.HoverForeColor = Color.FromArgb(43, 48, 59);
                    button.Style.PressedForeColor = Color.FromArgb(43, 48, 59);

                    // Button Image Color

                    button.Style.ImageForeColor = Color.FromArgb(107, 114, 128);
                    button.Style.FocusedImageForeColor = Color.FromArgb(43, 48, 59);
                    button.Style.HoverImageForeColor = Color.FromArgb(43, 48, 59);
                    button.Style.PressedImageForeColor = Color.FromArgb(43, 48, 59);

                }

                // Recursively check child controls
                if (control.HasChildren)
                {
                    ChildButton(control);
                }
            }
        }

        public static void BlueButton(SfButton button)
        {
            // Button Border

            button.Style.Border = null;
            button.Style.FocusedBorder = null;
            button.Style.HoverBorder = null;
            button.Style.PressedBorder = null;

            // Button BackColor

            button.Style.BackColor = Color.FromArgb(79, 143, 246);
            button.Style.PressedBackColor = Color.FromArgb(79, 143, 246);
            button.Style.HoverBackColor = Color.FromArgb(96, 154, 247);
            button.Style.FocusedBackColor = Color.FromArgb(79, 143, 246);

            // Button ForeColor

            button.Style.ForeColor = Color.White;
            button.Style.FocusedForeColor = Color.White;
            button.Style.HoverForeColor = Color.White;
            button.Style.PressedForeColor = Color.White;

            // Button Image Color

            button.Style.ImageForeColor = Color.White;
            button.Style.FocusedImageForeColor = Color.White;
            button.Style.HoverImageForeColor = Color.White;
            button.Style.PressedImageForeColor = Color.White;
        }

        public static void WhiteButton(SfButton button)
        {
            // Button Border

            button.Style.Border = new Pen(Color.Gainsboro);
            button.Style.PressedBorder = new Pen(Color.Gainsboro);
            button.Style.HoverBorder = new Pen(Color.Gainsboro);
            button.Style.FocusedBorder = new Pen(Color.Gainsboro);

            // Button BackColor

            button.Style.BackColor = Color.White;
            button.Style.PressedBackColor = Color.White;
            button.Style.HoverBackColor = Color.FromArgb(237, 237, 237);
            button.Style.FocusedBackColor = Color.White;

            // Button ForeColor

            button.Style.ForeColor = Color.FromArgb(43, 48, 59);
            button.Style.FocusedForeColor = Color.FromArgb(43, 48, 59);
            button.Style.HoverForeColor = Color.FromArgb(43, 48, 59);
            button.Style.PressedForeColor = Color.FromArgb(43, 48, 59);
        }
    }
}
