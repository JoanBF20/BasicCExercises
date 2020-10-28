using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsToDoList
{
    public partial class Form1 : Form
    {
        List<ToDoItem> todoList = new List<ToDoItem>();
        bool editing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                todoList[listBox1.SelectedIndex].Title = textBox1.Text;
            } else
            {
                ToDoItem item = new ToDoItem(textBox1.Text);
                todoList.Add(item);
                textBox1.Text = "";
            }
            updateList();
        }

        private void updateList()
        {
            listBox1.Items.Clear();
            editing = false;

            int count = 0;
            foreach (ToDoItem i in todoList)
            {
                count++;
                listBox1.Items.Add(count+". "+i.Title+" ( Complete: "+ i.IsCompleted+ " )");
            }
            updateLabels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                todoList.RemoveAt(listBox1.SelectedIndex);
                updateList();
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                if (todoList[index].IsCompleted)
                {
                    todoList[index].IsCompleted = false;
                    updateList();
                } else
                {
                    todoList[index].IsCompleted = true;
                    updateList();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox1.Text = todoList[listBox1.SelectedIndex].Title;
                editing = true;
                updateLabels();
            }
        }

        private void updateLabels()
        {
            if (editing)
            {
                label2.Text = "Edit ToDo Item";
                button3.Text = "Edit ToDo Item";
            } else
            {
                label2.Text = "New ToDo Item";
                button3.Text = "Add ToDo Item";
                textBox1.Text = "";
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (e.KeyCode == Keys.Down && index + 1 < this.listBox1.Items.Count && todoList.Count > 1)
            {
                ToDoItem item = todoList[index];
                todoList[index] = todoList[index + 1];
                todoList[index + 1] = item;
                updateList();
                listBox1.SelectedIndex = index;
            }
            if (e.KeyCode == Keys.Up && index - 1 > -1 && todoList.Count > 1)
            {
                ToDoItem item = todoList[index];
                todoList[index] = todoList[index - 1];
                todoList[index - 1] = item;
                updateList();
                listBox1.SelectedIndex = index;
            }
        }
    }
}
