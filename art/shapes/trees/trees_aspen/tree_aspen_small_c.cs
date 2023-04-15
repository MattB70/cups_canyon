
singleton TSShapeConstructor(Tree_aspen_small_cDae)
{
   baseShape = "./tree_aspen_small_c.dae";
   loadLights = "0";
};

function Tree_aspen_small_cDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
