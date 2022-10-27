namespace NET_1
{
    public static class Helper
    {
        public static void GenerateGuid(this MainEntity mainEntity)
        {
            mainEntity.Id = new Guid();
        }
    }
}
