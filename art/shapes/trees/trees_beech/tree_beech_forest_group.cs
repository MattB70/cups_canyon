
singleton TSShapeConstructor(Tree_beech_forest_groupDae)
{
   baseShape = "./tree_beech_forest_group.dae";
};

function Tree_beech_forest_groupDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
