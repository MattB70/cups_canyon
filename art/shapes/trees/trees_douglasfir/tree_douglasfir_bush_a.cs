
singleton TSShapeConstructor(Tree_douglasfir_bush_aDae)
{
   baseShape = "./tree_douglasfir_bush_a.dae";
   loadLights = "0";
};

function Tree_douglasfir_bush_aDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "1", "0");
}
