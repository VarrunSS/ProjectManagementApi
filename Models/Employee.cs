namespace ProjectManagementApi.Models {
    public class Employee {
        public Employee () {
            this.ID = "";
            this.Name = "";
            this.Designation = "";
            this.Experience = "";
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Experience { get; set; }

    }
}