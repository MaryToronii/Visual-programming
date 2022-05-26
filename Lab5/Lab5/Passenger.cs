using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{



    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class passengers
    {

        private List<passengersPassenger> passengerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("passenger")]
        public List<passengersPassenger> passenger
        {
            get
            {
                return this.passengerField;
            }
            set
            {
                this.passengerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class passengersPassenger
    {

        private string full_nameField;

        private byte count_thingField;

        private byte weight_1Field;

        private byte weight_2Field;

        private byte weight_3Field;

        private byte numberField;

        private string dateField;

        private string timeField;

        private string termField;

        private string destinationField;

        /// <remarks/>
        public string full_name
        {
            get
            {
                return this.full_nameField;
            }
            set
            {
                this.full_nameField = value;
            }
        }

        /// <remarks/>
        public byte count_thing
        {
            get
            {
                return this.count_thingField;
            }
            set
            {
                this.count_thingField = value;
            }
        }

        /// <remarks/>
        public byte weight_1
        {
            get
            {
                return this.weight_1Field;
            }
            set
            {
                this.weight_1Field = value;
            }
        }

        public byte weight_2
        {
            get
            {
                return this.weight_2Field;
            }
            set
            {
                this.weight_2Field = value;
            }
        }

        public byte weight_3
        {
            get
            {
                return this.weight_3Field;
            }
            set
            {
                this.weight_3Field = value;
            }
        }

        /// <remarks/>
        public byte number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public string time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        public string term
        {
            get
            {
                return this.termField;
            }
            set
            {
                this.termField = value;
            }
        }

        /// <remarks/>
        public string destination
        {
            get
            {
                return this.destinationField;
            }
            set
            {
                this.destinationField = value;
            }
        }
    }





}
