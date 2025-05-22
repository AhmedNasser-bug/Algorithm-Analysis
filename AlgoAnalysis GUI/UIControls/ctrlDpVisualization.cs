using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIControls
{
    public partial class ctrlDpVisualization : UserControl
    {
        public int MessageLimit = 10;

        int runtimeNotes = 0;
        int memoryNotes = 0;
        int notes = 0;
        public ctrlDpVisualization()
        {
            InitializeComponent();
        }

        public void AddRuntimeNote(string RunTimeNote)
        {
            
            if  ( runtimeNotes < MessageLimit)
            {
                flpRuntime.Controls.Add(Message(RunTimeNote));
            }
            else
            {
                flpRuntime.Controls[runtimeNotes % MessageLimit].Text = RunTimeNote;
                flpRuntime.Controls[runtimeNotes % MessageLimit].BackColor = Color.Yellow;

            }

            Task.Delay(500).Wait();
            flpRuntime.Controls[runtimeNotes % MessageLimit].BackColor = SystemColors.HotTrack;

            runtimeNotes++;
        }
        public void AddMemoryStateNote(string MemoryStateNote)
        {
            
            if (memoryNotes < MessageLimit)
            {
                flpState.Controls.Add(Message(MemoryStateNote));
            }
            else
            {
                flpState.Controls[memoryNotes % MessageLimit].Text = MemoryStateNote;
                flpState.Controls[memoryNotes % MessageLimit].BackColor = Color.Yellow;

            }

            Task.Delay(500).Wait();
            flpState.Controls[memoryNotes % MessageLimit].BackColor = SystemColors.HotTrack;

            memoryNotes++;
        }
        public void AddNote(string Note)
        {
            
            if (notes < MessageLimit)
            {
                flpNotes.Controls.Add(Message(Note));
            }
            else
            {
                flpNotes.Controls[notes % MessageLimit].Text = Note;
                flpNotes.Controls[notes % MessageLimit].BackColor = Color.Yellow;
            }

            Task.Delay(500).Wait();
            flpNotes.Controls[notes % MessageLimit].BackColor = SystemColors.HotTrack;

            notes++;

        }

        public void ResetNotes()
        {
            runtimeNotes = 0;
            memoryNotes = 0;
            notes = 0;
            flpNotes.Controls.Clear(); 
            flpRuntime.Controls.Clear(); 
            flpState.Controls.Clear(); 
        }



        #region Private members
        Label Message(string message)
        {
            Label lblMessage = new Label();
            lblMessage.BackColor = Color.Yellow;
            lblMessage.Font = new Font("SimSun-ExtB", 10f, FontStyle.Bold);
            lblMessage.ForeColor = Color.White;
            lblMessage.Location = new Point(10, 39);
            lblMessage.Margin = new Padding(10);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(327, 48);
            lblMessage.TabIndex = 34;
            lblMessage.Text = message;


            return lblMessage;
        }
        #endregion
    }
}
