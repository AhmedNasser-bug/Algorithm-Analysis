using MainGUIcsproj.Algorithm_Visualization;
using System.Diagnostics;

namespace MainGUIcsproj
{
    public partial class frmMainMenu : Form
    {
        public Control? CurrentControl;
        public static frmMainMenu? globalForm;
        public frmMainMenu()
        {
            InitializeComponent();

            // Add the main menu as the current control
            ctrlMainMenu mainMenu = new ctrlMainMenu();
            ChangeControl(mainMenu);
        }
        public void ChangeControl(Control newControl)
        {
            // Remove the previous control
            CurrentControl?.Hide();
            CurrentControl?.Dispose();
            Controls.Remove(CurrentControl);

            // Add the new control
            newControl.Dock = DockStyle.Fill;
            newControl.Enabled = true;
            newControl.Show();
            Controls.Add(newControl);

            // Set it as the current control
            CurrentControl = newControl;
        }



        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
