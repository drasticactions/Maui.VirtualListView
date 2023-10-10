namespace Microsoft.Maui;

public static class VirtualListViewHostBuilderExtensions
{
#if ANDROID || IOS || MACCATALYST || WINDOWS
	public static MauiAppBuilder UseVirtualListView(this MauiAppBuilder builder)
		=> builder.ConfigureMauiHandlers(handlers =>
			handlers.AddHandler(typeof(IVirtualListView), typeof(VirtualListViewHandler)));
#endif
}
