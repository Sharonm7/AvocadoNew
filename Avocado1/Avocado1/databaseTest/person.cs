using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
using Firebase.Database.Query;

namespace Avocado1.databaseTest
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }


        FirebaseClient firebase = new FirebaseClient("https://avocado1-a0c54.firebaseio.com/");
    }
}
