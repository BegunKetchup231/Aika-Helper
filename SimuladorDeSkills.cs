using System.Windows.Forms;

namespace AikaHelp_ByGrifinory
{
    public partial class SimuladorDeSkills : Form
    {
        private int pontosLabel5 = 0;
        private int pontosLabel6 = 0;
        private int pontosLabel7 = 0;
        private int pontosLabel8 = 0;
        private int pontosLabel9 = 0;
        private int pontosLabel10 = 0;

        private int pontosLabel11 = 0;
        private int pontosLabel12 = 0;
        private int pontosLabel13 = 0;
        private int pontosLabel14 = 0;
        private int pontosLabel15 = 0;
        private int pontosLabel16 = 0;

        private int pontosLabel17 = 0;
        private int pontosLabel18 = 0;
        private int pontosLabel19 = 0;
        private int pontosLabel20 = 0;
        private int pontosLabel21 = 0;
        private int pontosLabel22 = 0;

        private int pontosLabel23 = 0;
        private int pontosLabel24 = 0;
        private int pontosLabel25 = 0;
        private int pontosLabel26 = 0;
        private int pontosLabel27 = 0;
        private int pontosLabel28 = 0;

        private int pontosLabel29 = 0;
        private int pontosLabel30 = 0;
        private int pontosLabel31 = 0;
        private int pontosLabel32 = 0;
        private int pontosLabel33 = 0;
        private int pontosLabel34 = 0;

        private int pontosLabel35 = 0;


        public SimuladorDeSkills()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarSoma();
            AtualizarPontos();
            AtualizarLabels();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarSoma();
            AtualizarPontos();
            AtualizarLabels();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarSoma();
            AtualizarPontos();
            AtualizarLabels();
        }

        private static int CalcularPontos(int nivel)
        {
            if (nivel <= 50)
            {
                return nivel - 1;
            }
            else
            {
                return 2 * nivel - 101 + 50;
            }
        }

        private static int CalcularPontos2(int nivel2)
        {
            return nivel2 * 3;
        }

        private void AtualizarSoma()
        {
            int nivelSelecionado = comboBox1.SelectedIndex + 1; // Adicione 1 ao índice para obter o valor selecionado na ComboBox1.
            int valorComboBox2 = comboBox2.SelectedIndex + 1; // Adicione 1 ao índice para obter o valor selecionado na ComboBox2.
            int valorComboBox3 = comboBox3.SelectedIndex + 1; // Adiciona 1 ao índice para obter o valor de pontos trancedentais
            int pontos = CalcularPontos(nivelSelecionado) + CalcularPontos2(valorComboBox2);

            label2.Text = pontos.ToString();
            label4.Text = valorComboBox3.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void SimuladorDeSkills_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancela o fechamento padrão do formulário
            this.Hide(); // Oculta o formulário SimuladorDeSkills ao invés de fechá-lo
        }


        private void buttontemplaria_Click(object sender, EventArgs e)
        {
            SelectTemplaria();
        }
        private void buttonatirador_Click(object sender, EventArgs e)
        {
            SelectAtirador();
        }

        private void buttoncleriga_Click(object sender, EventArgs e)
        {
            SelectCleriga();
        }

        private void buttonfeiticeiro_Click(object sender, EventArgs e)
        {
            SelectFeiticeiro();
        }

        private void buttonguerreiro_Click(object sender, EventArgs e)
        {
            SelectGuerreiro();
        }

        private void buttonpistoleira_Click(object sender, EventArgs e)
        {
            SelectPistoleira();
        }


        private void AtualizarPontos()
        {
            pontosLabel5 = 0;
            pontosLabel6 = 0;
            pontosLabel7 = 0;
            pontosLabel8 = 0;
            pontosLabel9 = 0;
            pontosLabel10 = 0;

            pontosLabel11 = 0;
            pontosLabel12 = 0;
            pontosLabel13 = 0;
            pontosLabel14 = 0;
            pontosLabel15 = 0;
            pontosLabel16 = 0;

            pontosLabel17 = 0;
            pontosLabel18 = 0;
            pontosLabel19 = 0;
            pontosLabel20 = 0;
            pontosLabel21 = 0;
            pontosLabel22 = 0;

            pontosLabel23 = 0;
            pontosLabel24 = 0;
            pontosLabel25 = 0;
            pontosLabel26 = 0;
            pontosLabel27 = 0;
            pontosLabel28 = 0;

            pontosLabel29 = 0;
            pontosLabel30 = 0;
            pontosLabel31 = 0;
            pontosLabel32 = 0;
            pontosLabel33 = 0;
            pontosLabel34 = 0;

            pontosLabel35 = 0;

        }

        private void AtualizarLabels()
        {
            label5.Text = pontosLabel5.ToString();
            label6.Text = pontosLabel6.ToString();
            label7.Text = pontosLabel7.ToString();
            label8.Text = pontosLabel8.ToString();
            label9.Text = pontosLabel9.ToString();
            label10.Text = pontosLabel10.ToString();

            label11.Text = pontosLabel11.ToString();
            label12.Text = pontosLabel12.ToString();
            label13.Text = pontosLabel13.ToString();
            label14.Text = pontosLabel14.ToString();
            label15.Text = pontosLabel15.ToString();
            label16.Text = pontosLabel16.ToString();

            label17.Text = pontosLabel17.ToString();
            label18.Text = pontosLabel18.ToString();
            label19.Text = pontosLabel19.ToString();
            label20.Text = pontosLabel20.ToString();
            label21.Text = pontosLabel21.ToString();
            label22.Text = pontosLabel22.ToString();

            label23.Text = pontosLabel23.ToString();
            label24.Text = pontosLabel24.ToString();
            label25.Text = pontosLabel25.ToString();
            label26.Text = pontosLabel26.ToString();
            label27.Text = pontosLabel27.ToString();
            label28.Text = pontosLabel28.ToString();

            label29.Text = pontosLabel29.ToString();
            label30.Text = pontosLabel30.ToString();
            label31.Text = pontosLabel31.ToString();
            label32.Text = pontosLabel32.ToString();
            label33.Text = pontosLabel33.ToString();
            label34.Text = pontosLabel34.ToString();

            label35.Text = pontosLabel35.ToString();

        }

        private void SelectTemplaria()
        {
            // Página 1
            pictureBox1.Image = Properties.Resources.proficiencia_com_escudo;
            pictureBox2.Image = Properties.Resources.remediar;
            pictureBox3.Image = Properties.Resources.nemesis;
            pictureBox4.Image = Properties.Resources.incitar_multidao;
            pictureBox5.Image = Properties.Resources.guardiao;
            pictureBox6.Image = Properties.Resources.sangue_sagrado;
            // Página 2
            pictureBox7.Image = Properties.Resources.travar_alvo;
            pictureBox8.Image = Properties.Resources.defesa_concentrada;
            pictureBox9.Image = Properties.Resources.punicao;
            pictureBox10.Image = Properties.Resources.revelacao;
            pictureBox11.Image = Properties.Resources.uniao_divina;
            pictureBox12.Image = Properties.Resources.protecao;
            // Página 3
            pictureBox13.Image = Properties.Resources.emissao_divina;
            pictureBox14.Image = Properties.Resources.escudo_refletor;
            pictureBox15.Image = Properties.Resources.el_tycia;
            pictureBox16.Image = Properties.Resources.el_aster;
            pictureBox17.Image = Properties.Resources.el_thymos;
            pictureBox18.Image = Properties.Resources.el_aegis;
            // Página 4
            pictureBox19.Image = Properties.Resources.atracao_divina;
            pictureBox20.Image = Properties.Resources.defesa_automatica;
            pictureBox21.Image = Properties.Resources.lamina_da_promessa;
            pictureBox22.Image = Properties.Resources.santuario;
            pictureBox23.Image = Properties.Resources.julgamento;
            pictureBox24.Image = Properties.Resources.fe_imortal;
            // Página 5
            pictureBox25.Image = Properties.Resources.cruz_do_julgamento;
            pictureBox26.Image = Properties.Resources.carinho_do_ceu;
            pictureBox27.Image = Properties.Resources.carga_divina;
            pictureBox28.Image = Properties.Resources.escudo_celestial;
            pictureBox29.Image = Properties.Resources.forja_de_aço;
            pictureBox30.Image = Properties.Resources.salvador_imprudente;
            // Página 6
            pictureBox31.Image = Properties.Resources.escudo_vingador;
        }

        private void SelectAtirador()
        {
            // Página 1
            pictureBox1.Image = Properties.Resources.contagem_regressiva;
            pictureBox2.Image = Properties.Resources.tiro_fatal;
            pictureBox3.Image = Properties.Resources.tiro_angular;
            pictureBox4.Image = Properties.Resources.tiro_na_perna;
            pictureBox5.Image = Properties.Resources.ocultar;
            pictureBox6.Image = Properties.Resources.najmum;
            // Página 2
            pictureBox7.Image = Properties.Resources.perseguidor_implacavel;
            pictureBox8.Image = Properties.Resources.precisao;
            pictureBox9.Image = Properties.Resources.concentracao;
            pictureBox10.Image = Properties.Resources.poder_critico;
            pictureBox11.Image = Properties.Resources.detonacao;
            pictureBox12.Image = Properties.Resources.primeiro_encontro;
            // Página 3
            pictureBox13.Image = Properties.Resources.eliminar_alvo;
            pictureBox14.Image = Properties.Resources.rajada_sonica;
            pictureBox15.Image = Properties.Resources.ponto_vital;
            pictureBox16.Image = Properties.Resources.marca_do_perseguidor;
            pictureBox17.Image = Properties.Resources.demolicao_x14;
            pictureBox18.Image = Properties.Resources.contra_golpe;
            // Página 4
            pictureBox19.Image = Properties.Resources.ataque_atordoante;
            pictureBox20.Image = Properties.Resources.ultimato;
            pictureBox21.Image = Properties.Resources.posicao_de_atirador;
            pictureBox22.Image = Properties.Resources.visao_acurada;
            pictureBox23.Image = Properties.Resources.guarda_fatal;
            pictureBox24.Image = Properties.Resources.golpe_fantasma;
            // Página 5
            pictureBox25.Image = Properties.Resources.inspirar_matanca;
            pictureBox26.Image = Properties.Resources.sentenca_de_morte;
            pictureBox27.Image = Properties.Resources.postura_fantasma;
            pictureBox28.Image = Properties.Resources.explosao_napalm;
            pictureBox29.Image = Properties.Resources.armadilha_multipla;
            pictureBox30.Image = Properties.Resources.choro_de_chumbo;
            // Página 6
            pictureBox31.Image = Properties.Resources.destino;
        }

        private void SelectFeiticeiro()
        {
            // Página 1
            pictureBox1.Image = Properties.Resources.chama_caotica;
            pictureBox2.Image = Properties.Resources.sofrimento;
            pictureBox3.Image = Properties.Resources.polimorfo;
            pictureBox4.Image = Properties.Resources.onda_de_choque;
            pictureBox5.Image = Properties.Resources.escudo_negro;
            pictureBox6.Image = Properties.Resources.inferno_caotico;
            // Página 2
            pictureBox7.Image = Properties.Resources.impedimento;
            pictureBox8.Image = Properties.Resources.corroer;
            pictureBox9.Image = Properties.Resources.tempestade_de_mana;
            pictureBox10.Image = Properties.Resources.harmonia_de_mana;
            pictureBox11.Image = Properties.Resources.enxame_da_escuridao;
            pictureBox12.Image = Properties.Resources.eclater;
            // Página 3
            pictureBox13.Image = Properties.Resources.lanca_de_raio;
            pictureBox14.Image = Properties.Resources.esplendor_caotico;
            pictureBox15.Image = Properties.Resources.bruma_sonifera;
            pictureBox16.Image = Properties.Resources.mao_da_escuridao;
            pictureBox17.Image = Properties.Resources.teleporte_em_massa;
            pictureBox18.Image = Properties.Resources.queda_negra;
            // Página 4
            pictureBox19.Image = Properties.Resources.vinculo_quebrado;
            pictureBox20.Image = Properties.Resources.afinidade_negra;
            pictureBox21.Image = Properties.Resources.pecados_mortais;
            pictureBox22.Image = Properties.Resources.proeminencia;
            pictureBox23.Image = Properties.Resources.focar_magica;
            pictureBox24.Image = Properties.Resources.tempestade_de_raios;
            // Página 5
            pictureBox25.Image = Properties.Resources.nevoa_negra;
            pictureBox26.Image = Properties.Resources.explosao_das_trevas;
            pictureBox27.Image = Properties.Resources.trovao_ruinoso;
            pictureBox28.Image = Properties.Resources.cristalizar_mana;
            pictureBox29.Image = Properties.Resources.tempestade;
            pictureBox30.Image = Properties.Resources.furacao_negro;
            // Página 6
            pictureBox31.Image = Properties.Resources.portao_abissal;
        }

        private void SelectCleriga()
        {
            // Página 1
            pictureBox1.Image = Properties.Resources.flecha_sagrada;
            pictureBox2.Image = Properties.Resources.cura;
            pictureBox3.Image = Properties.Resources.escudo_magico;
            pictureBox4.Image = Properties.Resources.bencao;
            pictureBox5.Image = Properties.Resources.mao_da_cura;
            pictureBox6.Image = Properties.Resources.ressureicao;
            // Página 2
            pictureBox7.Image = Properties.Resources.velocidade;
            pictureBox8.Image = Properties.Resources.raio_solar;
            pictureBox9.Image = Properties.Resources.ativacao_divina;
            pictureBox10.Image = Properties.Resources.ativacao_de_mana;
            pictureBox11.Image = Properties.Resources.cura_em_massa_defensiva;
            pictureBox12.Image = Properties.Resources.uegenes_lux;
            // Página 3
            pictureBox13.Image = Properties.Resources.liberacao_de_mana;
            pictureBox14.Image = Properties.Resources.cura_preventiva;
            pictureBox15.Image = Properties.Resources.escudo_de_nikita;
            pictureBox16.Image = Properties.Resources.retorno_da_magica;
            pictureBox17.Image = Properties.Resources.golpe_divino;
            pictureBox18.Image = Properties.Resources.recuperacao;
            // Página 4
            pictureBox19.Image = Properties.Resources.afiar_arma;
            pictureBox20.Image = Properties.Resources.vontade_inabalavel;
            pictureBox21.Image = Properties.Resources.aura_explendor;
            pictureBox22.Image = Properties.Resources.escudo_sagrado;
            pictureBox23.Image = Properties.Resources.penitencia;
            pictureBox24.Image = Properties.Resources.gloria_de_excelsis;
            // Página 5
            pictureBox25.Image = Properties.Resources.cruz_penitencial;
            pictureBox26.Image = Properties.Resources.criacao_de_agua_benta;
            pictureBox27.Image = Properties.Resources.flores_da_gloria;
            pictureBox28.Image = Properties.Resources.cura_concentrada;
            pictureBox29.Image = Properties.Resources.pedra_da_alma;
            pictureBox30.Image = Properties.Resources.eden_piedoso;
            // Página 6
            pictureBox31.Image = Properties.Resources.dixit_dominus;
        }

        private void SelectGuerreiro()
        {
            // Página 1
            pictureBox1.Image = Properties.Resources.ataque_poderoso;
            pictureBox2.Image = Properties.Resources.avanco_poderoso;
            pictureBox3.Image = Properties.Resources.quebrar_armadura;
            pictureBox4.Image = Properties.Resources.incitar;
            pictureBox5.Image = Properties.Resources.furia;
            pictureBox6.Image = Properties.Resources.tempestade_de_laminas;
            // Página 2
            pictureBox7.Image = Properties.Resources.cancao_da_gloria;
            pictureBox8.Image = Properties.Resources.resoluto;
            pictureBox9.Image = Properties.Resources.fortitude;
            pictureBox10.Image = Properties.Resources.corpo_draconiano;
            pictureBox11.Image = Properties.Resources.cancao_da_bravura;
            pictureBox12.Image = Properties.Resources.area_de_impacto;
            // Página 3
            pictureBox13.Image = Properties.Resources.cancao_da_guerra;
            pictureBox14.Image = Properties.Resources.despertar;
            pictureBox15.Image = Properties.Resources.estocada;
            pictureBox16.Image = Properties.Resources.cancao_da_defesa;
            pictureBox17.Image = Properties.Resources.ferida_mortal;
            pictureBox18.Image = Properties.Resources.salto_de_impacto;
            // Página 4
            pictureBox19.Image = Properties.Resources.cancao_do_medo;
            pictureBox20.Image = Properties.Resources.inspirar_coragem;
            pictureBox21.Image = Properties.Resources.lamina_carregada;
            pictureBox22.Image = Properties.Resources.investida_mortal;
            pictureBox23.Image = Properties.Resources.instinto_de_batalha;
            pictureBox24.Image = Properties.Resources.mestre_da_espada;
            // Página 5
            pictureBox25.Image = Properties.Resources.pancada_de_sangue;
            pictureBox26.Image = Properties.Resources.uivo_da_liberdade;
            pictureBox27.Image = Properties.Resources.uivo_de_sangue;
            pictureBox28.Image = Properties.Resources.espada_sangrenta;
            pictureBox29.Image = Properties.Resources.poder_absoluto;
            pictureBox30.Image = Properties.Resources.limite_brutal;
            // Página 6
            pictureBox31.Image = Properties.Resources.postura_fnal;
        }

        private void SelectPistoleira()
        {
            // Página 1
            pictureBox1.Image = Properties.Resources.mjolnir;
            pictureBox2.Image = Properties.Resources.espinho_venenoso;
            pictureBox3.Image = Properties.Resources.acao_imediata;
            pictureBox4.Image = Properties.Resources.maximizar;
            pictureBox5.Image = Properties.Resources.ocultar_d;
            pictureBox6.Image = Properties.Resources.tiro_descontrolado;
            // Página 2
            pictureBox7.Image = Properties.Resources.veneno_da_lentidao;
            pictureBox8.Image = Properties.Resources.requiem;
            pictureBox9.Image = Properties.Resources.olhar_penetrante;
            pictureBox10.Image = Properties.Resources.movimento_gracioso;
            pictureBox11.Image = Properties.Resources.rosa_negra;
            pictureBox12.Image = Properties.Resources.veneno_de_mana;
            // Página 3
            pictureBox13.Image = Properties.Resources.fumaca_sangrenta;
            pictureBox14.Image = Properties.Resources.choque_subito;
            pictureBox15.Image = Properties.Resources.explosao_radiante;
            pictureBox16.Image = Properties.Resources.negar_cura;
            pictureBox17.Image = Properties.Resources.disparos_rapidos;
            pictureBox18.Image = Properties.Resources.estripador;
            // Página 4
            pictureBox19.Image = Properties.Resources.veneno_hidra;
            pictureBox20.Image = Properties.Resources.vento_cortante;
            pictureBox21.Image = Properties.Resources.rosa_sangrenta;
            pictureBox22.Image = Properties.Resources.choque_hidra;
            pictureBox23.Image = Properties.Resources.falsa_pontaria;
            pictureBox24.Image = Properties.Resources.disparo_demolidor;
            // Página 5
            pictureBox25.Image = Properties.Resources.dor_do_predador;
            pictureBox26.Image = Properties.Resources.morte_decidida;
            pictureBox27.Image = Properties.Resources.reacao_em_cadeia;
            pictureBox28.Image = Properties.Resources.ponto_cego;
            pictureBox29.Image = Properties.Resources.penetrar_armadura;
            pictureBox30.Image = Properties.Resources.festival_de_balas;
            // Página 6
            pictureBox31.Image = Properties.Resources.bomba_maldita;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (pontosLabel5 > 0)
            {
                pontosLabel5--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel5++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pontosLabel6 > 0)
            {
                pontosLabel6--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel6++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pontosLabel7 > 0)
            {
                pontosLabel7--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel7++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (pontosLabel8 > 0)
            {
                pontosLabel8--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel8++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (pontosLabel9 > 0)
            {
                pontosLabel9--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel9++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (pontosLabel10 > 0)
            {
                pontosLabel10--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel10++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (pontosLabel11 > 0)
            {
                pontosLabel11--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel11++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (pontosLabel12 > 0)
            {
                pontosLabel12--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel12++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (pontosLabel13 > 0)
            {
                pontosLabel13--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel13++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (pontosLabel14 > 0)
            {
                pontosLabel14--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel14++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (pontosLabel15 > 0)
            {
                pontosLabel15--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel15++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (pontosLabel16 > 0)
            {
                pontosLabel16--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel16++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (pontosLabel17 > 0)
            {
                pontosLabel17--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel17++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (pontosLabel18 > 0)
            {
                pontosLabel18--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel18++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (pontosLabel19 > 0)
            {
                pontosLabel19--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel19++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (pontosLabel20 > 0)
            {
                pontosLabel20--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel20++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (pontosLabel21 > 0)
            {
                pontosLabel21--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel21++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (pontosLabel22 > 0)
            {
                pontosLabel22--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel22++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (pontosLabel23 > 0)
            {
                pontosLabel23--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel23++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (pontosLabel24 > 0)
            {
                pontosLabel24--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel24++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (pontosLabel25 > 0)
            {
                pontosLabel25--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel25++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (pontosLabel26 > 0)
            {
                pontosLabel26--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel26++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (pontosLabel27 > 0)
            {
                pontosLabel27--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel27++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (pontosLabel28 > 0)
            {
                pontosLabel28--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel28++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (pontosLabel29 > 0)
            {
                pontosLabel29--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel29++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (pontosLabel30 > 0)
            {
                pontosLabel30--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel30++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (pontosLabel31 > 0)
            {
                pontosLabel31--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel31++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (pontosLabel32 > 0)
            {
                pontosLabel32--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel32++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (pontosLabel33 > 0)
            {
                pontosLabel33--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel33++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (pontosLabel34 > 0)
            {
                pontosLabel34--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel34++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (pontosLabel35 > 0)
            {
                pontosLabel35--;
                AtualizarLabels();

                int valorLabel2 = int.Parse(label2.Text);
                valorLabel2++;
                label2.Text = valorLabel2.ToString();
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            int valorLabel2 = int.Parse(label2.Text);

            if (valorLabel2 > 0)
            {
                pontosLabel35++;
                AtualizarLabels();

                valorLabel2--;
                label2.Text = valorLabel2.ToString();
            }
        }
    }
}
