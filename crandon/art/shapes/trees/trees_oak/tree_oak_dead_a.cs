
singleton TSShapeConstructor(Tree_oak_dead_aDae)
{
   baseShape = "./tree_oak_dead_a.dae";
   loadLights = "0";
};

function Tree_oak_dead_aDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
