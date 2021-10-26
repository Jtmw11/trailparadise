
singleton TSShapeConstructor(Tree_beech_dead_aDae)
{
   baseShape = "./tree_beech_dead_a.dae";
   loadLights = "0";
};

function Tree_beech_dead_aDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "1", "0");
}
