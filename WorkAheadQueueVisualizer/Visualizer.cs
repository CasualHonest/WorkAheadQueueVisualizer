using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WorkAheadQueueVisualizer
{

    public partial class Visualizer : Form
    {
        List<QueueElement> elements = new List<QueueElement>();
        public Visualizer()
        {
            InitializeComponent();
        }

        private void Visualizer_Load(object sender, EventArgs e)
        {
            ResetFrontThreePreview();
        }

        private void BTN_Enqueue_Click(object sender, EventArgs e)
        {
            if (!CheckInputBeingValid(TXT_NewEle.Text, TXT_NewVal.Text))
                return;

            QueueElement element = new QueueElement(TXT_NewEle.Text, TXT_NewVal.Text);
            if (elements.Count == 0)
            {
                elements.Add(element);
                LST_Queue.Items.Add(element);
            }
            else
            {
                if (!CheckIndexBeingValid(LST_Queue.SelectedIndex))
                    return;

                elements.Insert(LST_Queue.SelectedIndex + 1, element);
                LST_Queue.Items.Insert(LST_Queue.SelectedIndex + 1, element);
            }
            UpdateFrontThreeElementDisplay();
        }

        private void BTN_OverWrite_Click(object sender, EventArgs e)
        {
            if (!CheckInputBeingValid(TXT_NewEle.Text, TXT_NewVal.Text)
                || !CheckIndexBeingValid(LST_Queue.SelectedIndex))
                return;

            QueueElement element = new QueueElement(TXT_NewEle.Text, TXT_NewVal.Text);
            if (elements.Count == 0)
            {
                elements.Add(element);
                LST_Queue.Items.Add(element);
            }
            else
            {
                if (!CheckIndexBeingValid(LST_Queue.SelectedIndex))
                    return;

                elements[LST_Queue.SelectedIndex] = element;
                LST_Queue.Items[LST_Queue.SelectedIndex] = element;
            }
            UpdateFrontThreeElementDisplay();
        }

        private void BTN_Dequeue_Click(object sender, EventArgs e)
        {
            if (!CheckIndexBeingValid(LST_Queue.SelectedIndex))
                return;

            QueueElement temp = elements[LST_Queue.SelectedIndex];
            txtDeqEle.Text = temp.Element.ToString();
            txtDeqVal.Text = temp.Value.ToString();

            elements.RemoveAt(LST_Queue.SelectedIndex);
            LST_Queue.Items.RemoveAt(LST_Queue.SelectedIndex);
            UpdateFrontThreeElementDisplay();
        }

        private void UpdateFrontThreeElementDisplay()
        {
            ResetFrontThreePreview();
            for (int i = 0; i < ((elements.Count < 3) ? elements.Count : 3); i++)
            {
                switch (i)
                {
                    case 0:
                        TXT_FirstEle.Text = elements[i].Element.ToString();
                        TXT_FirstVal.Text = elements[i].Value.ToString();
                        break;
                    case 1:
                        TXT_SecondEle.Text = elements[i].Element.ToString();
                        TXT_SecondVal.Text = elements[i].Value.ToString();
                        break;
                    case 2:
                        TXT_ThirdEle.Text = elements[i].Element.ToString();
                        TXT_ThirdVal.Text = elements[i].Value.ToString();
                        break;
                }
            }
        }

        private bool CheckInputBeingValid(string S1, string S2)
        {
            if (string.IsNullOrWhiteSpace(S1) || string.IsNullOrWhiteSpace(S2))
            {
                MessageBox.Show("Please enter in all information needed to create an element", "Input Error");
                return false;
            }
            return true;
        }

        private bool CheckIndexBeingValid(int Index)
        {
            if (elements.Count < Index || Index == -1)
            {
                MessageBox.Show("Please select an element to add/modify/delete", "Selection Error");
                return false;
            }
            return true;
        }

        private void ResetFrontThreePreview()
        {
            TXT_FirstEle.Text = "N/A";
            TXT_FirstVal.Text = "N/A";
            TXT_SecondEle.Text = "N/A";
            TXT_SecondVal.Text = "N/A";
            TXT_ThirdEle.Text = "N/A";
            TXT_ThirdVal.Text = "N/A";
        }
    }
}
