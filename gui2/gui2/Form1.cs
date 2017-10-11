using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gui2
{
    public partial class Form1 : Form
    {
        //create Binding Source instance.
        private BindingSource listBindingSource = new BindingSource();
        //create and set applicaionr global variables.
        string countSort = "descending";
        string itemCodeSort = "ascending";
        string onOrderSort = "descending";
        string currentSort = "Currently Sorted by \"Item Code\" - Ascending Order";
        bool fileLoaded = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //SAVE button
        private void button1_Click(object sender, EventArgs e)
        {
            //get the file name the user typed into the text box.
            string fileName = textBox1.Text;

            //check if there is a file open
            if (fileLoaded == false)
            {
                MessageBox.Show("No file is open.", "Error", MessageBoxButtons.OK);
            }

            //check if the user has typed something into the textbox
            else if (fileName == "")
            {
                //if text box is empty show error message with ok button
                MessageBox.Show("Please Enter a File Name.", "Error", MessageBoxButtons.OK);
            }

            //check if a file type has been selected, if not show error message
            else if (fileTypeBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid file type.", "Error", MessageBoxButtons.OK);
            }

            //if user has typed something then save the file
            else
            {
                
                fileName = fileName + fileTypeBox.SelectedItem;
                
                DialogResult result = MessageBox.Show("Are you sure you want to save file: " + fileName + "\n" + label3.Text, "Confirm Save", MessageBoxButtons.OKCancel);

                //if user clicks ok and has select .csv
                if (result == DialogResult.OK && fileName.EndsWith(".csv"))
                {

                     List<Stock> csvValues = listBindingSource.DataSource as List<Stock>;

                     //create a string for the first line in the new .csv file
                     string text1 = "Item Code,Item Description,Current Count,On Order\r\n";
                     //creat a file in the StockFile directory called what ever is stored in fileName variable
                     //write string from text1 variable to newly created file
                     File.WriteAllText(@"C:\StockFile\" + fileName, text1);

                     //grab all items form csvValues, sort them by itemCode and store them in itemSearch1
                     //old code don't need anymore var itemSearch1 = csvValues.OrderBy(p => p.itemCode);

                     //for each item in list<T> create a string
                    foreach (var item in csvValues)
                    {

                         string text = item.itemCode + "," + item.description + "," + item.count + "," + item.onOrder;
                         //open newly created file with streamWriter.
                         using (StreamWriter outputFile = new StreamWriter(@"C:\StockFile\" + fileName, true))
                         {
                             //write string text to new line in open file.
                             outputFile.WriteLine(text);
                         }

                    }
                    //once file is saved open it to show user.
                    System.Diagnostics.Process.Start(@"C:\StockFile\" + fileName);
                    //clear the text box and reset drop down list
                    textBox1.Text = "";
                    fileTypeBox.Text = "File Type";
                }

                //if user clicks ok and has select .xml
                if (result == DialogResult.OK && fileName.EndsWith(".xml"))
                {
                    //create xml decleration
                    string text1 = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n";
                    string text2;

                    //check wich style sheet button is checked
                    if (styleButton1.Checked)
                    {
                        //link to style sheet 1
                        text2 = "<?xml-stylesheet type=\"text/xsl\" href=\"style1.xsl\"?>";
                    }
                    else if (styleButton2.Checked)
                    {
                        //link to style sheet 2
                        text2 = "<?xml-stylesheet type=\"text/xsl\" href=\"style2.xsl\"?>";
                    }
                    else
                    {
                        //no style sheet to link to
                        text2 = "";
                    }
                   

                    List<Stock> csvValues = listBindingSource.DataSource as List<Stock>;

                     
                     //create a file in the StockFile directory called what ever is stored in fileName variable
                     //write string from text1 variable to newly created file
                     File.WriteAllText(@"C:\StockFile\" + fileName, text1);

                     //id varable which will be added to the stockItem element so I can grab different rows for editing in style sheet
                     int id = 1;
                     using (StreamWriter outputFile = new StreamWriter(@"C:\StockFile\" + fileName, true))
                     {
                        //write string text to new line in open file.
                        
                         outputFile.WriteLine(text2);
                        //link to schema file
                         outputFile.WriteLine("<stockItems xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:noNamespaceSchemaLocation = \"schema.xsd\" > ");

                        //populate xml elements with values from list csvValues
                        foreach (var item in csvValues)
                         {
                            outputFile.WriteLine("<stockItem id=\"" + id + "\">");
                            outputFile.WriteLine("<itemCode>" + item.itemCode + "</itemCode>");
                            outputFile.WriteLine("<itemDescription>" + item.description + "</itemDescription>");
                            outputFile.WriteLine("<currentCount>" + item.count + "</currentCount>");
                            outputFile.WriteLine("<onOrder>" + item.onOrder + "</onOrder>");
                            outputFile.WriteLine("</stockItem>");
                            id++;
                         }

                         outputFile.WriteLine("</stockItems>");
                        }
                    //once file is saved open it to show user.
                    System.Diagnostics.Process.Start(@"C:\StockFile\" + fileName);
                    //clear the text box, and reset drop down list.
                    textBox1.Text = "";
                    fileTypeBox.Text = "File Type";
                }

                //clear the text box, and reset drop down list.
                textBox1.Text = "";
                fileTypeBox.Text = "File Type";
            }

        }

        //Sortby Current Count Button
        private void button2_Click(object sender, EventArgs e)
        {
            //set variables
            onOrderSort = "descending";
            itemCodeSort = "descending";
           //check if there is a file open.
           //If no file open then show error message.
            if(fileLoaded == false)
            {
                MessageBox.Show("Nothing to sort, open a file first.", "Error", MessageBoxButtons.OK);
            }
            //sort in ascending order on count column
            else if (countSort != "ascending")
            {
                SortAscending(s => s.count, "Current Count");
                countSort = "ascending";
            }
            //sort in descending order on the count column
            else
            {
                SortDescending(s => s.count, "Current Count");
                countSort = "descedning";
            }
            

        }

        //Sortby Item Code Button
        private void button4_Click(object sender, EventArgs e)
        {
            onOrderSort = "descending";
            countSort = "descending";

            //check if there is a file open.
            //If no file open then show error message.
            if (fileLoaded == false)
            {
                MessageBox.Show("Nothing to sort, open a file first.", "Error", MessageBoxButtons.OK);
            }
            //sort ascending order on itCode column
            else if (itemCodeSort != "ascending")
            {
                SortAscending(s => s.itemCode, "Item Code");
                itemCodeSort = "ascending";
            }
            //sort in descending order on itemCode column
            else
            {
                SortDescending(s => s.itemCode, "Item Code");
                itemCodeSort = "descending";
            }
        }

        //Sortby On Order Button
        private void button3_Click(object sender, EventArgs e)
        {
            itemCodeSort = "descending";
            countSort = "descending";

            //check if there is a file open.
            //If no file open then show error message.
            if (fileLoaded == false)
            {
                MessageBox.Show("Nothing to sort, open a file first.", "Error", MessageBoxButtons.OK);
            }
            //sort in ascending order on onOrder column
            else if (onOrderSort != "ascending")
            {
                SortAscending(s => s.onOrder, "On Order");
                onOrderSort = "ascending";
            }
            //sort in descending order on onOrder column
            else
            {
                SortDescending(s => s.onOrder, "On Order");
                onOrderSort = "descending";
            }
        }

        //Open File Button
        private void openDialog_Click(object sender, EventArgs e)
        {
            //grab user entered filename from text box
            string fileName = fileNameTextBox.Text;

            //check if user added ".csv" to the filename
            //if ".csv" is missing then add it.
            if (!fileName.EndsWith(".csv"))
            {
                fileName = fileName + ".csv";
            }

            //file name path
            string path = @"C:\StockFile\" + fileName;
            //check if user file exists
            if (File.Exists(path))
            {
                
                //create a new list<T>
                List<Stock> csvValues = new List<Stock>();
                //read all the lines of the file (skipping the first line) and return
                //them to an array.
                var list = File.ReadAllLines(path).Skip(1);
                
                
                foreach (var item in list)
                {
                    //for each item in list create a variable called stock and run the ItemsFromCsv method
                    var stock = Stock.ItemsFromCsv(item);
                    //ass stock to the csvValues list.
                    csvValues.Add(stock);
                }
                
                
                //set the datasource for the data binding
                listBindingSource.DataSource = csvValues;
                //populate the datagrid with the binding source
                dataGridView1.DataSource = listBindingSource;

                //Setting headings for each column in dataGridView1
                dataGridView1.Columns[0].HeaderText = "Item Code:";
                dataGridView1.Columns[1].HeaderText = "Description:";
                dataGridView1.Columns[2].HeaderText = "Current Count:";
                //Centering text in Current Count Column
                dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[3].HeaderText = "On Order:";
                //Centering text in On Order Column
                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //Making columns 0, 1 and 3 read only (user can't edit)
                //Making column 2 editable by user (Current Count column)
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = false;
                dataGridView1.Columns[3].ReadOnly = true;

                label3.Text = currentSort;
                currentFileLabel.Text = "Current File: C:\\StockFile\\" + fileName;

                //Sets variable fileLoad to true 
                fileLoaded = true;

            }
            else
            {
                //if file doesn't exists show error message
                MessageBox.Show("Can not find file: " + fileName + " \r\nPlease check spelling.", "Error", MessageBoxButtons.OK);
            }

            //Clear the text box.
            fileNameTextBox.Text = "";
            

        }

        /*sort ascending order method
         * creates a list of type stock and populates it from the list binding datasource.
         * sorts the list in ascening order using LINQ query.
         * assigns the data binding source to the csvVaules list.
         * Populates the data grid view with the binding source.
         * sets the sorted by text according to method string parameter.
         */
        private void SortAscending(Func<Stock, object> s, string text)
        {
            List<Stock> csvValues = listBindingSource.DataSource as List<Stock>;
            csvValues = csvValues.OrderBy(s).ToList();
            listBindingSource.DataSource = csvValues;
            dataGridView1.DataSource = listBindingSource;
            label3.Text = "Currently Sorted by " + text + " - Ascending Order";
        }
        
        /*sort descending order method
         * creates a list of type stock and populates it from the list binding datasource.
         * sorts the list in descening order using LINQ query.
         * assigns the data binding source to the csvVaules list.
         * Populates the data grid view with the binding source.
         * sets the sorted by text according to method string parameter.
         */

        private void SortDescending(Func<Stock, object> s, string text)
        {
            List<Stock> csvValues = listBindingSource.DataSource as List<Stock>;
            csvValues = csvValues.OrderByDescending(s).ToList();
            listBindingSource.DataSource = csvValues;
            dataGridView1.DataSource = listBindingSource;
            label3.Text = "Currently Sorted by " + text + " - Descending Order";
        }

        
    }

    class Stock
    {
        /*creating properties of class Stock*/
        public string itemCode { get; set; }
        public string description { get; set; }
        public int count { get; set; }
        public string onOrder { get; set; }

        /*The method takes a string parameter and splits it up into an array where ever there is a comma
         * Creates a new insatnce of Stock called stock.
         * then assigns array index 0 to item.Code
         * array index 1 to description
         * array index 2 to count
         * and array index 3 to onOrder properties.
         * then returns stock.
         */
        public static Stock ItemsFromCsv(string item)
        {
            string[] values = item.Split(',');
            Stock stock = new Stock();
            stock.itemCode = values[0];
            stock.description = values[1];
            stock.count = int.Parse(values[2]);
            stock.onOrder = values[3];
            return stock;
        }  
    }
}
