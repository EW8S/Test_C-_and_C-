using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C_Sharp
{
    public partial class Form1 : Form
    {
        private List<Person> person = new List<Person>();
        private int index = -1;

        WorkWithFile workWithFile = new WorkWithFile();

        public Form1()
        {
            InitializeComponent();

            //Reading a collection from a file
            person = workWithFile.loadData();
            if (person != null)
            {
                //Данные на ListView
                updateListView();
            }
        }

        // Saving data to a file
        private void saveSource()
        {
            //Data to file
            workWithFile.saveSource(person);
            //Clear data entry fields
            clearEnter();
            //Downloading from the updated data file
            person = workWithFile.loadData();
            //update Listview
            updateListView();
        }

        //Event when selecting data on the ListView
        private void lv_person_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lv_person.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lv_person.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                //Get the record number
                index = intselectedindex;

                //Display in the data entry fields
                txId.Text = person[intselectedindex].getId().ToString();
                txFirstName.Text = person[intselectedindex].getFirst_name();
                txSecondName.Text = person[intselectedindex].getSecond_name();
            }
        }

        //Update or output data to listview
        private void updateListView()
        {
            //Clear Listview
            lv_person.Items.Clear();
            //Filling the listview from the Person object
            for (int i = 0; i < person.Count; i++)
            {
                lv_person.Items.Add(person[i].getId().ToString());
                lv_person.Items[i].SubItems.Add(person[i].getFirst_name());
                lv_person.Items[i].SubItems.Add(person[i].getSecond_name());
            }
        }

        //Button Apply 
        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (index != -1)    
                {
                    //Editing a Collection
                    person[index].setId(int.Parse(txId.Text));
                    person[index].setFirst_name(txFirstName.Text);
                    person[index].setSecond_name(txSecondName.Text);

                    //Saving and updating data
                    saveSource();
                }
            }
            catch (Exception ex)
            {
                //If an error occurred while entering data
                Console.WriteLine(ex.Message);
                MessageBox.Show("Enter the correct values", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        //
        private void clearEnter()
        {
            //Clear input fields
            txId.Text = "";
            txFirstName.Text = "";
            txSecondName.Text = "";
            //reset variable with the correction number for the collection
            index = -1;
        }

        //Delete record button
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                person.RemoveAt(index);
                saveSource();
            }
        }

        //Add record button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                person.Add(new Person(int.Parse(txId.Text), txFirstName.Text, txSecondName.Text));
                saveSource();
            } catch (Exception ex){
                Console.WriteLine(ex.Message);
                MessageBox.Show("Enter the correct values", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            
        }
    }
}
