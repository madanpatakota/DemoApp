namespace DemoApp.APIs.DTOs
{

    //If some one ask me that the data of Custoemr then i will give the response in below format....
    public class CustomerReadDTO
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }

    }
}
