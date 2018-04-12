namespace ProjectManagementApi.Models {
    public class UserTask : Employee {
        public UserTask () {
            this.TaskType = string.Empty;
            this.Team = string.Empty;
            this.TaskName = string.Empty;
            this.Summary = string.Empty;
            this.Difficulty = string.Empty;
        }

        public string TaskType { get; set; }
        public string Team { get; set; }
        public string TaskName { get; set; }
        public string Summary { get; set; }
        public string Difficulty { get; set; }
    }
}