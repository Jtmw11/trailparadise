
singleton TSShapeConstructor(Tree_aspen_large_aDae)
{
   baseShape = "./tree_aspen_large_a.dae";
   loadLights = "0";
};

function Tree_aspen_large_aDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
