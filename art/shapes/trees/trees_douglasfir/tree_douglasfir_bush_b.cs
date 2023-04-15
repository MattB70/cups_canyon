
singleton TSShapeConstructor(Tree_douglasfir_bush_bDae)
{
   baseShape = "./tree_douglasfir_bush_b.dae";
   loadLights = "0";
};

function Tree_douglasfir_bush_bDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "1", "0");
}
