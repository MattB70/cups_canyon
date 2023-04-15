
singleton TSShapeConstructor(Tree_douglasfir_large_dDae)
{
   baseShape = "./tree_douglasfir_large_d.dae";
   loadLights = "0";
};

function Tree_douglasfir_large_dDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
