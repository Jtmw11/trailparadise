
singleton TSShapeConstructor(Tree_beech_small_bDae)
{
   baseShape = "./tree_beech_small_b.dae";
};

function Tree_beech_small_bDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
