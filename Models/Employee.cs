namespace ProjectManagementApi.Models {
    public class Employee {
        public Employee () {
            this.ID = string.Empty;
            this.Name = string.Empty;
            this.Designation = string.Empty;
            this.Experience = string.Empty;
            this.Team = string.Empty;
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Experience { get; set; }
        public string Team { get; set; }

    }
}