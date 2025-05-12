namespace CMS.BLL.DTO.Requests.user.Department
{
    public class GetDepRequestDto
    {
        public string Name { get; set; } = string.Empty;
        public string DepID { get; set; } = string.Empty;
        public string? HDDID { get; set; }
    }


}