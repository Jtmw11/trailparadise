// This is the default save location for any Decal datablocks created in the
// Decal Editor (this script is executed from onServerCreated())

datablock DecalData(decal_roadmarkings)
{
   size = "5.5";
   Material = "roadmarkings";
   fadeStartPixelSize = "20";
   fadeEndPixelSize = "10";
   renderPriority = "8";
   frame = "4";
   randomize = "0";
   textureCoordCount = "15";
   texRows = "4";
   texCols = "4";
   textureCoords[1] = "0.25 0 0.25 0.25";
   textureCoords[2] = "0.5 0 0.25 0.25";
   textureCoords[3] = "0.75 0 0.25 0.25";
   textureCoords[4] = "0 0.25 0.25 0.25";
   textureCoords[5] = "0.25 0.25 0.25 0.25";
   textureCoords[6] = "0.5 0.25 0.25 0.25";
   textureCoords[7] = "0.75 0.25 0.25 0.25";
   textureCoords[8] = "0 0.5 0.25 0.25";
   textureCoords[9] = "0.25 0.5 0.25 0.25";
   textureCoords[10] = "0.5 0.5 0.25 0.25";
   textureCoords[11] = "0.75 0.5 0.25 0.25";
   textureCoords[12] = "0 0.75 0.25 0.25";
   textureCoords[13] = "0.25 0.75 0.25 0.25";
   textureCoords[14] = "0.5 0.75 0.25 0.25";
   textureCoords[15] = "0.75 0.75 0.25 0.25";
   textureCoords[0] = "0 0 0.25 0.25";
};

datablock DecalData(road_01_tracks_large_decal_01d)
{
    Material = "Road_01_tracks_large_decal_01";
    textureCoordCount = "3";
    randomize = "1";
    texRows = "2";
    texCols = "2";
    textureCoords[0] = "0 0 0.5 0.5";
    textureCoords[1] = "0.5 0 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    size = "15";
    frame = "1";
};

datablock DecalData(decal_terrain_transitions)
{
    Material = "terrain_transitions";
    textureCoordCount = "3";
    texRows = "2";
    texCols = "2";
    textureCoords[0] = "0 0 0.5 0.5";
    textureCoords[1] = "0.5 0 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    size = "7";
    frame = "0";
    fadeStartPixelSize = "20";
    fadeEndPixelSize = "10";
    renderPriority = "79";
   randomize = "0";
};

datablock DecalData(decal_scrapes)
{
    Material = "scrapes";
    textureCoordCount = "3";
    texRows = "2";
    texCols = "2";
    textureCoords[0] = "0 0 0.5 0.5";
    textureCoords[1] = "0.5 0 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    size = "7";
    frame = "0";
    fadeStartPixelSize = "20";
    fadeEndPixelSize = "10";
    renderPriority = "79";
   randomize = "0";
};

datablock DecalData(decal_oilstains)
{
    Material = "oilstains";
    textureCoordCount = "3";
    texRows = "2";
    texCols = "2";
    textureCoords[0] = "0 0 0.5 0.5";
    textureCoords[1] = "0.5 0 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    size = "7";
    frame = "3";
    fadeStartPixelSize = "20";
    fadeEndPixelSize = "10";
    renderPriority = "79";
   randomize = "1";
};

datablock DecalData(decals_sponsors)
{
    Material = "sponsors";
    textureCoordCount = "3";
    texRows = "2";
    texCols = "2";
    textureCoords[0] = "0 0 0.5 0.5";
    textureCoords[1] = "0.5 0 0.5 0.5";
    textureCoords[2] = "0 0.5 0.5 0.5";
    textureCoords[3] = "0.5 0.5 0.5 0.5";
    size = "12";
    frame = "1";
    fadeStartPixelSize = "20";
    fadeEndPixelSize = "10";
    renderPriority = "80";
   randomize = "0";
};

