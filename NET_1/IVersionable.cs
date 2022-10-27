namespace NET_1
{
    public interface IVersionable
    {
        byte[] GetVersion();
        void SetVersion(byte[] arr);

        const int ArraySize = 8;
    }
}
