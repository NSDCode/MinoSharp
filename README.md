# MinoSharp
Simple C# API Wrapper for minotar.net's API.


#Usage: 

##Item types:

HEAD
BODY
BUST
CUBE
SKIN
HELMET

##File formats:

JPG
PNG

##Functions:

GetItem(string username, int size, ITEMS_COLLECTION item, IMAGE_FORMATS format)

username: the username of the player

size: size of the image (in pixels)

item: type of data you want to get

format: image format

SaveItem(string username, string path, int size, ITEMS_COLLECTION item, IMAGE_FORMATS format)

username: the username of the player

path: the place where you want your image to be saved

size: size of the image (in pixels)

item: type of data you want to get

format: image format
