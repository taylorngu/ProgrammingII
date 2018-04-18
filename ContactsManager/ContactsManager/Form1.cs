using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContactsManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Person contact = new Person();
            Address contactAD = new Address();

            contact.firstName = txtFName.Text;
            contact.lastName = txtLName.Text;

            contactAD.street = txtStreetAD.Text;
            contactAD.city = txtCity.Text;
            contactAD.state = txtState.Text;

            Contact newContact = new Contact();
            newContact

        }

    }

    public class Person
    {
    
        public string firstName {get; set;}
        public string lastName {get; set;}
    
    }

    public class Address
    {

        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; } 
    
    }

    public class Contact
    {
    
        public Person contactPerson {get; set;}
        public 
            
            
            
            Address contactAD {get; set;}
    
    }

    public static class AddressBook
    { 
        
        public static List<Contact> addressBook = new List<Contact> ();

    }
}
