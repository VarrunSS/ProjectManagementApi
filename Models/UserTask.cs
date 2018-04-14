namespace ProjectManagementApi.Models {
    public class UserTask : Employee {
        public UserTask () {
            this.TaskType = string.Empty;
            this.Summary = string.Empty;
            this.Difficulty = string.Empty;
            this.CompletionInDays = 0;
        }

        public string TaskType { get; set; }
        public string Summary { get; set; }
        public string Difficulty { get; set; }
        public decimal CompletionInDays { get; set; }
    }
}