
singleton TSShapeConstructor(Tree_douglasfir_small_bDae)
{
   baseShape = "./tree_douglasfir_small_b.dae";
   loadLights = "0";
};

function Tree_douglasfir_small_bDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
