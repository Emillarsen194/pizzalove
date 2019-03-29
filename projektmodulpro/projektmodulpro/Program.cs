    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace projektmodulpro
{
    class Retrieve_all_info
    {


        #region looks nice
        static DirectoryEntry myLdapConnection;
        static DirectorySearcher search;
        static SearchResult result;
        static string userChoice; //Used in menu
        #endregion

        static void Main(string[] args)
        {
            while (1 == 1)
            {
                Console.Clear();
                Console.WriteLine("Choose one");
                Console.WriteLine("");
                Console.WriteLine("[1] Find all information about user");
                Console.WriteLine("");
                Console.WriteLine("[2] Find information about all users");
                Console.WriteLine("");
                Console.WriteLine("[3] Update a user");
                Console.WriteLine("");
                Console.Write("I choose: ");
                userChoice = Console.ReadLine();
                Console.Clear();
                Menu();
                Console.ReadLine();
            }
        }


        static void Menu()
        {
            switch (userChoice)
            {
                case "1":
                    FindAllInfo();
                    break;
                case "2":
                    FindAllUsers();
          
                    break;
                case "3":
                    UpdateUser();
                    
                    break;
            }
            return;
        }

        static void FindAllInfo()
        {
            Console.Write("Enter user fx. Jakob JAWA. Waidow: ");
            String username = Console.ReadLine();

            try
            {
                // create LDAP connection object  

                //mLdapConnetion is our connection to AD if there is no result comming out
                ///Check for the right connection string
                DirectoryEntry myLdapConnection = createDirectoryEntry();

                // create search object which operates on LDAP connection object  
                // and set search object to only find the user specified  

                ///Search filter becomes what we typed at the start                
                search = new DirectorySearcher(myLdapConnection);
                search.Filter = "(cn=" + username + ")"; 

                // create results objects from search object  
                result = search.FindOne();

                IsFound();
            }


            catch (Exception e)
            {
                Console.WriteLine("Exception caught:\n\n" + e.ToString());
            }


            return;
        }

        static void IsFound()
        {
            ///When result is found 
            if (result != null)
            {
                // user exists, cycle through LDAP fields (cn, telephonenumber etc.)  

                ResultPropertyCollection fields = result.Properties;

                ///Searches for all results that have pur input inside?
                foreach (String ldapField in fields.PropertyNames)
                {
                    // cycle through objects in each field e.g. group membership  
                    // (for many fields there will only be one object such as name)  

                    foreach (Object myCollection in fields[ldapField])
                        Console.WriteLine(String.Format("{0,-20} : {1}",
                                      ldapField, myCollection.ToString()));
                }
            }
            ///If it cant find the user
            ///IT will not say this if connetion string is wrong
            else
            {
                // user does not exist  
                Console.WriteLine("User not found!");
            }

        }
        /// <summary>
        /// Connection for our AD
        /// </summary>
        /// 

        static void FindAllUsers()
        {
            Console.Write("Enter property example initials: ");
            String property = Console.ReadLine(); /// enters a property like a mail or ini 

            try
            {
                DirectoryEntry myLdapConnection = createDirectoryEntry();

                DirectorySearcher search = new DirectorySearcher(myLdapConnection); 
                search.PropertiesToLoad.Add("cn"); /// adding all the common names in the domain
                search.PropertiesToLoad.Add(property); /// adds the item we search for in our property
         

                SearchResultCollection allUsers = search.FindAll(); /// makes a collection out of our search

                foreach (SearchResult result in allUsers)  // foreach result in our all users collection 
                {
                    if (result.Properties["cn"].Count > 0 && result.Properties[property].Count > 0)
                    {
                        Console.WriteLine(String.Format("{0,-20} : {1}", /// prints all of our results 
                                      result.Properties["cn"][0].ToString(), 
                                      result.Properties[property][0].ToString()));
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception caught:\n\n" + e.ToString());
            }
        }


        static void UpdateUser()
        {
            UpdateUserMenu();
            byte whattoupdate = byte.Parse(Console.ReadLine());

            string property = "";
            switch (whattoupdate)
            {
                case 1:
                    property = "mail";
                    break;
                case 2: property = "displayname";
                    break;
                case 3:
                    property = "title";
                    break;
            }

     

                Console.Write("Enter user      : ");
                String username = Console.ReadLine();

                try
                {
                    DirectoryEntry myLdapConnection = createDirectoryEntry(); /// makes the connection

                    DirectorySearcher search = new DirectorySearcher(myLdapConnection); 
                    search.Filter = "(cn=" + username + ")"; /// search for common name username
                    search.PropertiesToLoad.Add(property); //loads the properties we want to update 

                    SearchResult result = search.FindOne(); // finds user 

                    if (result != null) // if it found anything run this code
                    {
                        // create new object from search result  

                        DirectoryEntry entryToUpdate = result.GetDirectoryEntry();

                    // show existing properti  

                    Console.WriteLine("Current " + property + " : " + // writes our current property
                                      entryToUpdate.Properties[property][0].ToString()); 
                  

                        Console.Write("\n\nEnter new " + property + " : ");

                        // get new title and write to AD  

                        String newProperty = Console.ReadLine();

                        entryToUpdate.Properties[property].Value = newProperty; /// update the property
                        entryToUpdate.CommitChanges(); /// commit the changes to ad

                        Console.WriteLine("\n\n...new " + property  + " saved"); /// new property saved
                    }

                    else Console.WriteLine("User not found!"); //if we dident find any user
                }

                catch (Exception e)
                {
                    Console.WriteLine("Exception caught:\n\n" + e.ToString());
                }
            }

        static void UpdateUserMenu() /// just a menu we can choose from
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What do u wish to update?");
            Console.WriteLine();
            Console.WriteLine("1. Mail");
            Console.WriteLine();
            Console.WriteLine("2. Display Name");
            Console.WriteLine();
            Console.WriteLine("3. title");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("choose one: ");

        }
        

        static DirectoryEntry createDirectoryEntry()
        {
            // create and return new LDAP connection with desired settings  


            ///Some other way we can connect in the future
            DirectoryEntry ldapConnection = new DirectoryEntry("LDAP://192.168.0.2", "Administrator", "Emil1234E", AuthenticationTypes.Secure);


            //DirectoryEntry ldapConnection = new DirectoryEntry("MMDA.DK");
            ///We only need a path if we want to be very specific in what OU we want to look for
            //ldapConnection.Path = "LDAP://OU=Miljømærkering DK,DC=MMDA,DC=dk"; ///We are searching for it in miljømærkering
            ldapConnection.AuthenticationType = AuthenticationTypes.Secure; ///makes secure connetion?

            return ldapConnection;
        }
    }
   
    }


