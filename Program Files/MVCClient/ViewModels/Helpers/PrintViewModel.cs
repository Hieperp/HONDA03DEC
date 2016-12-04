namespace MVCClient.ViewModels.Helpers
{
    public class PrintViewModel
    {
        public int Id { get; set; }

        public string ServerName { get { return "SERVERCTY"; } set; }
        public string CatalogName { get { return "TESTTotalBikePortals"; } set; }

        public string ReportPath { get; set; }

        public int PrintOptionID { get; set; }
    }
}