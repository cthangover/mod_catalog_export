# Catalog Export — publish a mod in a mod catalog

A mod catalog is a JSON list the mod manager downloads mods from. Catalog Export writes a mod's entry for such a catalog — names and descriptions per language, category, tags, version limits, changelog, download link — and packs the mod into the archive the entry points to, with SHA-256 checksums of the archive and of the installed files.

## Opening it

Hammer button on the in-game toolbar → **Export Catalog Entry**.

## Exporting a mod

![Export Catalog Entry for the ui_base mod: the form with the mod's id, name, version and author, Download URL, Status, Min Game Version, Icon URL, Tags and the category buttons on the left; the resulting JSON on the right; Copy JSON and Export to File at the top.](assets/catalog-export.jpg)

1. **Select a mod**. The form is filled from its manifest.
2. Fill **Download URL** (where the archive will be uploaded; required), **Icon URL**, **Category**, **Tags (comma-separated)**, **Min Game Version**, **Status** and **Changelog**. **Add language** adds a name and a description in another language.
3. The preview shows the resulting JSON. **Copy JSON** puts it on the clipboard.
4. **Export to File**: for a folder mod, a `.zip` archive and its `.json` entry are written into the mods folder; for a mod that is already a `.zip`, only the `.json` is written next to it. The status line shows the written path.

Upload the archive to the download URL and add the entry to your catalog; the mod manager then offers the mod for installation.

## Dependencies

`tools_base`, `ui_base`. It uses the game's catalog and archive code and does not need the mod manager window.
The older `editor_tools` package installs this mod together with the other authoring windows.
