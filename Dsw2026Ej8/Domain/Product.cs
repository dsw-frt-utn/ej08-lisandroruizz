using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Domain
{
        public class Product
        {
            private string description;

            public Product(string description)
            {
                this.description = description;
            }

            public string GetDescription()
            {
                return description;
            }

            public void ChangeDescription(string newDescription)
            {
                description = newDescription;
            }
        }
    }
