using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Net.Http.Headers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Poc.WinApp.LinkedList
{
    public partial class Form1 : Form
    {
        LinkedList<ProductionDataModel> productions = new();

        private RadioButton selectedrb;
        private E_OrderStatuses selectedStatus;
        public Form1()
        {
            InitializeComponent();

            this.radioButton1.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.radioButton2.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.radioButton3.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.radioButton4.CheckedChanged += new EventHandler(radioButton_CheckedChanged);

            buttonAddTop.Click += ButtonAddTop_Click;
            buttonAddAfter.Click += ButtonBelow_Click;
            buttonAddLast.Click += ButtonAddLast_Click;
            buttonAddBefore.Click += ButtonAddAbove_Click;
            buttonRemove.Click += ButtonRemove_Click;
            buttonClear1.Click += ButtonClear1_Click;
            buttonClear2.Click += ButtonClear2_Click;
            buttonMoveUp.Click += ButtonMoveUp_Click;
            buttonMoveDown.Click += ButtonMoveDown_Click;
        }

       

        #region "ButtonClick"

        private void ButtonMoveUp_Click(object? sender, EventArgs e)
        {
            MoveUp();
        }

        private void ButtonMoveDown_Click(object? sender, EventArgs e)
        {
            MoveDown();
        }

        private void ButtonClear2_Click(object? sender, EventArgs e)
        {
            textBoxFind.Clear();
        }

        private void ButtonClear1_Click(object? sender, EventArgs e)
        {
            textBoxValue.Clear();
        }

        private void ButtonRemove_Click(object? sender, EventArgs e)
        {
            if (textBoxFind.Text != string.Empty && MessageBox.Show($"Do you want to remove {textBoxFind.Text}?", "Remove", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var foundData = FindValue(textBoxFind.Text);
                if (foundData != null)
                {
                    productions.Remove(foundData);
                }
                DisplayMembers();
            }
        }

        private void ButtonAddAbove_Click(object? sender, EventArgs e)
        {
            var founddata = FindValue(textBoxFind.Text);

            if (founddata != null)
            {
                AddBefore(founddata, AddList(textBoxValue.Text, selectedStatus));
            }
        }

        private void ButtonAddLast_Click(object? sender, EventArgs e)
        {
            AddtoBottom(textBoxValue.Text, selectedStatus);
        }

        private void ButtonBelow_Click(object? sender, EventArgs e)
        {
            var founddata = FindValue(textBoxFind.Text);

            if (founddata != null)
            {
                AddAfter(founddata, AddList(textBoxValue.Text, selectedStatus));
            }
        }

        private void ButtonAddTop_Click(object? sender, EventArgs e)
        {
            AddtoTop(textBoxValue.Text, selectedStatus);
        }

        #endregion

        #region "Linked List"

        private void AddAfter(ProductionDataModel current, ProductionDataModel newNode)
        {
            productions.AddAfter(productions.Find(current), newNode);
            DisplayMembers();
        }

        private void AddtoTop(string value, E_OrderStatuses status)
        {
            productions.AddFirst(AddList(value, status));
            DisplayMembers();
        }

        private void AddtoBottom(string value, E_OrderStatuses status)
        {
            productions.AddLast(AddList(value, status));
            DisplayMembers();
        }

        private void AddBefore(ProductionDataModel current, ProductionDataModel newNode)
        {
            productions.AddBefore(productions.Find(current), newNode);
            DisplayMembers();
        }

        private void MoveUp()
        {
            var current = FindValue(textBoxFind.Text);
            if (current != null)
            {
                var previous = productions.Find(current).Previous;
                productions.Remove(current);
                productions.AddBefore(previous, CreateNode(current));
                DisplayMembers();
            }
        }

        private void MoveDown()
        {
            var current = FindValue(textBoxFind.Text);
            if (current != null)
            {
                var next = productions.Find(current).Next;
                productions.Remove(current);
                productions.AddAfter(next, CreateNode(current));
                DisplayMembers();
            }
        }

        private ProductionDataModel AddList(string orderNo, E_OrderStatuses status)
        {
            ProductionDataModel productionDataModel = new()
            {
                GUID = Guid.NewGuid(),
                OrderNo = orderNo,
                OrderStatus = status
            };

            return productionDataModel;
        }

        private LinkedListNode<ProductionDataModel> CreateNode(ProductionDataModel dataModel)
        {
            LinkedListNode<ProductionDataModel> node = new(dataModel);
            return node;
        }

        private ProductionDataModel FindValue(string orderNo)
        {
            ProductionDataModel foundData = null;

            foreach (ProductionDataModel item in productions)
            {
                if (item.OrderNo == orderNo)
                {
                    foundData = item;
                    break;
                }
            }

            return foundData;
        }

        #endregion


        private void radioButton_CheckedChanged(object? sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton == null)
            {
                return;
            }

            if (radioButton.Checked)
            {
                selectedrb = radioButton;
            }

            switch (selectedrb.Text)
            {
                case "Available":
                    selectedStatus = E_OrderStatuses.Available;
                    break;
                case "Producing":
                    selectedStatus = E_OrderStatuses.Producing;
                    break;
                case "Complete":
                    selectedStatus = E_OrderStatuses.Complete;
                    break;
                case "Cancel":
                    selectedStatus = E_OrderStatuses.Cancel;
                    break;
            }
        }


        private void DisplayMembers()
        {
            string data = string.Empty;

            foreach (var item in productions)
            {
                data += string.Concat(item.GUID, " ", item.OrderNo, " ", item.OrderStatus.ToString(), Environment.NewLine);
            }

            textBoxData.Text = data;

            ClearAllTexts();
        }

        private void ClearAllTexts()
        {
            textBoxFind.Clear();
            textBoxValue.Clear();
        }
    }
}