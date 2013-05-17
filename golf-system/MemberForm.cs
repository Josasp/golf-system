using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace golf_system
{
    public partial class MemberForm : Form
    {
        private Member m;

        //Form state, can be ACTION, EDIT, NEW, VIEW
        private String state = "ACTION";

        public MemberForm(Member m)
        {
            this.m = m;
            InitializeComponent();

            if (m.IsEmpty)
            {
                state = "NEW";
            }

            if (state.Equals("NEW"))
            {
                this.Text = "Ny Medlem";
                action_button.Text = "Skapa";
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
