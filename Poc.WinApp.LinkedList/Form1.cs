using System.Collections.Generic;

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
            buttonBelow.Click += ButtonBelow_Click;
            buttonAddLast.Click += ButtonAddLast_Click;
        }

        private void ButtonAddLast_Click(object? sender, EventArgs e)
        {
            AddtoBottom();
        }

        private void ButtonBelow_Click(object? sender, EventArgs e)
        {

        }

        private void ButtonAddTop_Click(object? sender, EventArgs e)
        {
            AddtoTop();
        }

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

        private void AddtoTop()
        {
            productions.AddFirst(AddList(textBoxValue.Text, selectedStatus));
            DisplayMembers();
        }

        private void AddtoBottom()
        {
            productions.AddLast(AddList(textBoxValue.Text, selectedStatus));
            DisplayMembers();
        }

        private void AddAbove(string orderNo)
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

            if (foundData != null)
            {
                var current = productions.Find(foundData);

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
        }
    }
}