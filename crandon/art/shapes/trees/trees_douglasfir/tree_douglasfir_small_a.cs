
singleton TSShapeConstructor(Tree_douglasfir_small_aDae)
{
   baseShape = "./tree_douglasfir_small_a.dae";
};

function Tree_douglasfir_small_aDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
