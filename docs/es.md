# Exportar catálogo — publica un mod en un catálogo de mods

Un catálogo de mods es una lista JSON desde la que el gestor de mods descarga mods. Exportar catálogo escribe la entrada de un mod para ese catálogo (nombres y descripciones por idioma, categoría, etiquetas, versiones, cambios, enlace de descarga) y empaqueta el mod en el archivo al que apunta la entrada, con sumas SHA-256 del archivo y de los archivos instalados.

## Cómo abrirlo

Botón del martillo en la barra del juego → **Exportar entrada del catálogo**.

## Exportar un mod

![Exportar entrada del catálogo para el mod ui_base: a la izquierda el formulario con id, nombre, versión y autor del mod, URL de descarga, Estado, Versión mínima del juego, URL del icono, Etiquetas y los botones de categoría; a la derecha el JSON resultante; arriba Copiar JSON y Exportar a archivo.](assets/catalog-export.jpg)

1. **Selecciona un mod**. El formulario se rellena desde su manifiesto.
2. Rellena **URL de descarga** (donde se subirá el archivo; obligatoria), **URL del icono**, **Categoría**, **Etiquetas (separadas por comas)**, **Versión mínima del juego**, **Estado** y **Cambios**. **Añadir idioma** añade un nombre y una descripción en otro idioma.
3. **JSON resultante** muestra el resultado. **Copiar JSON** lo copia al portapapeles.
4. **Exportar a archivo**: para un mod de carpeta se escriben en la carpeta de mods un archivo `.zip` y su entrada `.json`; para un mod que ya es `.zip`, solo se escribe el `.json` a su lado. La línea de estado muestra la ruta escrita.

Sube el archivo al enlace de descarga y añade la entrada a tu catálogo; el gestor de mods ofrecerá el mod para instalar.

## Dependencias

`tools_base`, `ui_base`. Usa el código de catálogos y archivos del propio juego; no necesita la ventana del gestor de mods.
El paquete antiguo `editor_tools` instala este mod junto con las demás ventanas de autor.
