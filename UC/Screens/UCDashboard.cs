using StockMate.Helpers;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMate.UC.Screens
{
    public partial class UCDashboard : UserControl
    {
        public UCDashboard()
        {
            InitializeComponent();
            PanelsAndChild();
        }

        private void PanelsAndChild()
        {
            GradientPanel[] panels = { panelAddProducts, panelAddSuppliers, panelAddBorrower, panelViewReports };
            foreach (var pnl in panels)
            {
                pnl.BorderStyle = BorderStyle.FixedSingle;
                pnl.BorderSingle = ButtonBorderStyle.Dashed;
                pnl.BorderColor = Color.Gainsboro;
                pnl.MouseMove += QuickActionStyle;
                pnl.MouseLeave += QuickActionMouseLeave;

                foreach (Control child in pnl.Controls)
                {
                    pnl.MouseMove += QuickActionStyle;
                    pnl.MouseLeave += QuickActionMouseLeave;
                }
            }
        }

        private void QuickActionMouseLeave(object? sender, EventArgs e)
        {
            GradientPanel pnl = GetParentPanel(sender);
            if (pnl != null)
            {
                var mousePos = pnl.PointToClient(Control.MousePosition);
                if (!pnl.ClientRectangle.Contains(mousePos))
                {
                    pnl.BorderColor = Color.Gainsboro;
                }
            }
        }

        private void QuickActionStyle(object sender, EventArgs e)
        {
            GradientPanel pnl = GetParentPanel(sender);
            if (pnl != null)
            {
                pnl.BorderColor = Color.FromArgb(59, 130, 245);
            }
        }

        private GradientPanel GetParentPanel(object sender)
        {
            if (sender is GradientPanel)
                return (GradientPanel)sender;
            else if (sender is Control ctrl && ctrl.Parent is GradientPanel pnl)
                return pnl;
            else
                return null;
        }
    }
}
