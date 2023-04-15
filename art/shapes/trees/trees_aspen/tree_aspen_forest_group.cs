
singleton TSShapeConstructor(Tree_aspen_forest_groupDae)
{
   baseShape = "./tree_aspen_forest_group.dae";
   loadLights = "0";
};

function Tree_aspen_forest_groupDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
