namespace DemoApp.APIs.DTOs
{

    //If some one ask me that the data of Custoemr then i will give the response in below format....
    public class CustomerReadDTO1CustomerReadDTO
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }

    }


    //Id , Name and adress

    public class CustomerReadDTO1
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        //public string CustomerCity { get; set; }

    }




    public class CustomerCreateDTO
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
    }


    public class CustomerUpdateDTO
    {
        public string CustomerAddress { get; set; }

        public string CustomerCity { get; set; }
    }



}
