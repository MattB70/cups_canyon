
singleton TSShapeConstructor(Tree_douglasfir_group_lowDae)
{
   baseShape = "./tree_douglasfir_group_low.dae";
   loadLights = "0";
};

function Tree_douglasfir_group_lowDae::onLoad(%this)
{
   %this.addImposter("25", "8", "0", "0", "512", "1", "0");
}
