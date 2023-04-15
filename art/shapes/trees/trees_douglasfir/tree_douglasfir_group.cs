
singleton TSShapeConstructor(Tree_douglasfir_groupDae)
{
   baseShape = "./tree_douglasfir_group.dae";
   loadLights = "0";
};

function Tree_douglasfir_groupDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
