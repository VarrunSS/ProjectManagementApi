namespace ProjectManagementApi.Models {
    public class Performance {
        public Performance () {
            this.TeamName = string.Empty;
            this.TeamSize = 0;
            this.TotalTaskCompleted = 0;
        }

        public string TeamName { get; set; }
        public int TeamSize { get; set; }
        public int TotalTaskCompleted { get; set; }
    }
}