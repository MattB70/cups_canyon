
singleton TSShapeConstructor(Tree_douglasfir_small_dDae)
{
   baseShape = "./tree_douglasfir_small_d.dae";
   loadLights = "0";
};

function Tree_douglasfir_small_dDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "1", "0");
}
