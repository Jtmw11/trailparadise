
singleton TSShapeConstructor(Tree_oak_forest_bDae)
{
   baseShape = "./tree_oak_forest_b.dae";
   loadLights = "0";
};

function Tree_oak_forest_bDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
