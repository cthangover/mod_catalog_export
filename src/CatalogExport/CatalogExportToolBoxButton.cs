namespace Cthangover.Core.UI.Tool.CatalogExport
{
    /// <summary>Exposes catalog export in the in-game toolbar's tools list.</summary>
    public class CatalogExportToolBoxButton : IToolBoxButton
    {
        /// <inheritdoc />
        public string ToolId => "catalog_export";

        /// <inheritdoc />
        public string IconPath => "";

        /// <inheritdoc />
        public string LocaleKey => "mods/catalog_title";

        /// <inheritdoc />
        public bool IsVisible() => true;
    }
}
