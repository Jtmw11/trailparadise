
singleton TSShapeConstructor(Tree_beech_bush_eDae)
{
   baseShape = "./tree_beech_bush_e.dae";
   loadLights = "0";
};

function Tree_beech_bush_eDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "1", "0");
}
