namespace MSTL.Interface
{
    public interface IMvxComposeEmailTask
    {
        void ComposeEmail(string to, string cc, string subject, string body, bool isHtml);
    }
}