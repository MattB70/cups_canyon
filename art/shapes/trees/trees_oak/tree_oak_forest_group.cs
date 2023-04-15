
singleton TSShapeConstructor(Tree_oak_forest_groupDae)
{
   baseShape = "./tree_oak_forest_group.dae";
};

function Tree_oak_forest_groupDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
