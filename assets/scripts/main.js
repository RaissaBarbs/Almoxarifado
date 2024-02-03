const buttonClick = document.getElementById("btnGravar");

buttonClick.addEventListener("click", function(){
    console.log("Clicou em gravar");
    const objIDDep = document.getElementById("idDepartamento");
    const objNomeDep = document.getElementById("idDepartamento");
    const objData = document.getElementById("idDepartamento");

  const campos = document.querySelectorAll('[data-obigatorio="true"]')
   let TemCampoVazio = false;

  campos.forEach(function(itemElemento){
    console.log(itemElemento.value);
    if (itemElemento.value==""){
        itemElemento.computedStyleMap.backgroundColor="red";
    } else{
        itemElemento.computedStyleMap.backgroundColor="#ffffff";
    }
  })
if (TemCampoVazio){
    return;
}

  console.log("final do gravar");
})
 
function adicionarCorFundoAofocar(){
    const inputs = document.querySelectorAll('input,select');

    inputs.forEach(function(itemElemento){
        itemElemento.addEventListener('focus', function(){
            itemElemento.style.backgroundColor= "green";
            itemElemento.style.color="white"
        });
        itemElemento.addEventListener('blur', function(){
            itemElemento.style.backgroundColor= "ffffff";
            itemElemento.style.color="000000"
        });
    })
   
}
function adicionarCamposAceitarSomenteInteiro(){
   const campos = document.querySelectorAll('[data-soInteiroPositivo="true"]')
   campos.forEach(function (item){
    const teclasAceitas = [48,49,50,51,52,53,54,55,56,57,99,97,98,99,100,101,102,103,104,105]
    item.addEventListener('keyup', function(e){
        console.log(e.keycode);
        if(!teclasAceitas.includes(e.keyCode)){
          item.value="";
        }
    })
   })
}
function carregarCategoria(){
    const elementCategoria = document.getElementById("categoriaMotivo");
    categorias.forEach(function (objCat){
        let opt = document.createElement('option');
        opt.text = objCat.Descricao;
        opt.value = objCat.idCategoria;
        elementCategoria.appendChild(opt);
    })

}

function carregarMotivoAoAlterarcategoria() {
    const elementCategoria = document.getElementById("categoriaMotivo");

    elementCategoria.addEventListener("change", function() {
        let valorEscolhido = elementCategoria.value;
        const motivosFiltrados =
        motivos.filter((obj)=> obj.idCategoria==valorEscolhido)

        const elementoMotivo = document.getElementById("Motivo");
        elementoMotivo.innerHTML="";
        motivosFiltrados.forEach(function(item){
            let opt = document.createElement('option');
            opt.text = item.Descricao;
            opt.value = item.idMotivo;
            elementoMotivo.appendChild(opt);
        })
    })
}
function carregarNomeDepartamentoaoAlterarIDDep(){
    const elementIdDep = document.getElementById("idDepartamento");
    elementIdDep.addEventListener("keyup", function(){
      const valorPesquisado = elementIdDep.value;
      const departamentoEncontrado = departamento.find((dep)=>dep.codigo==valorPesquisar);
   
      if(departamentoEncontrado!=underfined){
       document.getElementById("departamento").value= departamentoEncontrado.Descricao;
      }else{
       document.getElementById("departamento").value=""
      }
   
    })
}



function carregarNomeCargoFuncionarioAoAlterarIDFunc(){
    const elementIdFunc = document.getElementById("idFuncionario");
    elementIdFunc.addEventListener("keyup", function(){
   const valorPesquisado = elementIdFunc.value;
   const encontrado = funcionarios.find((obj)=>obj.Codigo==valorPesquisar);

   if(encontrado!=underfined){
    document.getElementById("Nomefuncionario").value= encontrado.Nome;
    document.getElementById("Cargo").value= encontrado.Cargo;
   }else{
    document.getElementById("Nomefuncionario").value=""
    document.getElementById("Cargo").value=""
   }

 })
}

function carregarProdutoPorID(){
    const elementIdProd = document.getElementById("CodigoProduto");
    elementIdProd.addEventListener("keyup", function(){
    const valorPesquisar = elementIdProd.value;
    const produtoEncontrado =
    produtos.find((obj)=>obj.idProduto==valorPesquisar);

    if (produtoEncontrado!=undefined){
        document.getElementById("DescricaoProduto").value=
        produtoEncontrado.Descricao;
        document.getElementById("Estoque").value=
        produtoEncontrado.Estoque;
        
        let cor = verificarRegraPercentualEstoqueMinimo(produtoEncontrado);
        const elementoImg = document.getElementById("imgStatus")
        if(cor=="verde"){
            console.log(elementoImg);
            elementoImg.src="/assets/img/verde.png";
        }else if (cor=="vermelho"){
            elementoImg.src="/assets/img/vermelho.png";
        }else {
            elementoImg.src="/assets/img/amarelo.png";
        }
    }else{
        document.getElementById("DescricaoProduto").value=""
        document.getElementById("Estoque").value="";
    }
    
    })
}

function verificarRegraPercentualEstoqueMinimo(pProduto){
    let vPerc10 = Math.round(pProduto.EstoqueMinimo*10/100)
                             + pProduto.EstoqueMinimo
    console.log(vPerc10);
    if(pProduto.Estoque>vPerc10){
        return "verde";
    }else if (pProduto.Estoque<pProduto.EstoqueMinimo){
        return "vermelho";
    }else{
        return "amarelo";
    }
}
document.getElementById('BtnInserirItens')
                       addEventListener('click', function(){
    const tabelaItens = document.getElementById("tabelaItens");

    let codigoProduto = document.getElementById("CodigoProduto").value;
    let quantidade = document.getElementById("Quantidade").value;
    const produtoEncontrado = 
    produtos.find((obj)=>obj.idProduto==codigoProduto);

    const linha = createElement.document("tr");

    const tdCodigo = document.createElement("td");
    const tdDescricao= document.createElement("td");
    const tdQuantidade = document.createElement("td");
    const tdUnidade = document.createElement("td");
    const tdPreco = document.createElement("td");
    const tdTotal = document.createElement("td");

    tdCodigo.innerHTML= codigoProduto;
    tdDescricao.innerHTML= produtoEncontrado.Descricao;
    tdQuantidade.innerHTML=quantidade;
    tdUnidade.innerHTML=produtoEncontrado.Unidade;
    tdPreco.innerHTML=produtoEncontrado.Preco;
    tdTotal.innerHTML=produtoEncontrado.Preco*quantidade;
    linha.appendChild(tdCodigo);
    linha.appendChild(tdDescricao);
    linha.appendChild(tdQuantidade);
    linha.appendChild(tdUnidade);
    linha.appendChild(tdPreco);
    linha.appendChild(tdTotal);
    tabelaItens.appendChild(linha);
 })

carregarProdutoPorID();
carregarNomeCargoFuncionarioAoAlterarIDFunc();
carregarNomeDepartamentoaoAlterarIDDep();
carregarMotivoaoAlterarCategoria();
carregarCategoria();
adicionarCorFundoAofocar();
adicionarCamposAceitarSomenteInteiro();