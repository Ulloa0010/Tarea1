namespace Tarea1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ltitulo = new System.Windows.Forms.Label();
            this.pconfiguracion = new System.Windows.Forms.Panel();
            this.biniciar = new System.Windows.Forms.Button();
            this.bdosjugadores = new System.Windows.Forms.Button();
            this.bindividual = new System.Windows.Forms.Button();
            this.tnombre2 = new System.Windows.Forms.TextBox();
            this.lnombre2 = new System.Windows.Forms.Label();
            this.tnombre1 = new System.Windows.Forms.TextBox();
            this.lnombre1 = new System.Windows.Forms.Label();
            this.pjuego = new System.Windows.Forms.Panel();
            this.lnombreturno = new System.Windows.Forms.Label();
            this.lturno = new System.Windows.Forms.Label();
            this.lvidas = new System.Windows.Forms.Label();
            this.labelvidas = new System.Windows.Forms.Label();
            this.lfallos = new System.Windows.Forms.Label();
            this.laciertos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnivel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnum2 = new System.Windows.Forms.Label();
            this.bcomprobar = new System.Windows.Forms.Button();
            this.tresultado = new System.Windows.Forms.TextBox();
            this.lnum1 = new System.Windows.Forms.Label();
            this.lop = new System.Windows.Forms.Label();
            this.presultados = new System.Windows.Forms.Panel();
            this.pconfiguracion.SuspendLayout();
            this.pjuego.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.Location = new System.Drawing.Point(171, 9);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Size = new System.Drawing.Size(242, 31);
            this.ltitulo.TabIndex = 0;
            this.ltitulo.Text = "Juego de Numeros";
            // 
            // pconfiguracion
            // 
            this.pconfiguracion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pconfiguracion.Controls.Add(this.biniciar);
            this.pconfiguracion.Controls.Add(this.bdosjugadores);
            this.pconfiguracion.Controls.Add(this.bindividual);
            this.pconfiguracion.Controls.Add(this.tnombre2);
            this.pconfiguracion.Controls.Add(this.lnombre2);
            this.pconfiguracion.Controls.Add(this.tnombre1);
            this.pconfiguracion.Controls.Add(this.lnombre1);
            this.pconfiguracion.Location = new System.Drawing.Point(18, 43);
            this.pconfiguracion.Name = "pconfiguracion";
            this.pconfiguracion.Size = new System.Drawing.Size(549, 187);
            this.pconfiguracion.TabIndex = 1;
            // 
            // biniciar
            // 
            this.biniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.biniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biniciar.Location = new System.Drawing.Point(220, 124);
            this.biniciar.Name = "biniciar";
            this.biniciar.Size = new System.Drawing.Size(107, 46);
            this.biniciar.TabIndex = 6;
            this.biniciar.Text = "Iniciar";
            this.biniciar.UseVisualStyleBackColor = false;
            this.biniciar.Click += new System.EventHandler(this.biniciar_Click);
            // 
            // bdosjugadores
            // 
            this.bdosjugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdosjugadores.Location = new System.Drawing.Point(291, 18);
            this.bdosjugadores.Name = "bdosjugadores";
            this.bdosjugadores.Size = new System.Drawing.Size(120, 38);
            this.bdosjugadores.TabIndex = 5;
            this.bdosjugadores.Text = "2 jugadores";
            this.bdosjugadores.UseVisualStyleBackColor = true;
            // 
            // bindividual
            // 
            this.bindividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindividual.Location = new System.Drawing.Point(133, 18);
            this.bindividual.Name = "bindividual";
            this.bindividual.Size = new System.Drawing.Size(120, 38);
            this.bindividual.TabIndex = 4;
            this.bindividual.Text = "1 jugador";
            this.bindividual.UseVisualStyleBackColor = true;
            // 
            // tnombre2
            // 
            this.tnombre2.Location = new System.Drawing.Point(291, 98);
            this.tnombre2.Name = "tnombre2";
            this.tnombre2.Size = new System.Drawing.Size(136, 20);
            this.tnombre2.TabIndex = 3;
            // 
            // lnombre2
            // 
            this.lnombre2.AutoSize = true;
            this.lnombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnombre2.Location = new System.Drawing.Point(287, 75);
            this.lnombre2.Name = "lnombre2";
            this.lnombre2.Size = new System.Drawing.Size(144, 20);
            this.lnombre2.TabIndex = 2;
            this.lnombre2.Text = "Nombre Jugador 2:";
            // 
            // tnombre1
            // 
            this.tnombre1.Location = new System.Drawing.Point(113, 98);
            this.tnombre1.Name = "tnombre1";
            this.tnombre1.Size = new System.Drawing.Size(136, 20);
            this.tnombre1.TabIndex = 1;
            // 
            // lnombre1
            // 
            this.lnombre1.AutoSize = true;
            this.lnombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnombre1.Location = new System.Drawing.Point(109, 75);
            this.lnombre1.Name = "lnombre1";
            this.lnombre1.Size = new System.Drawing.Size(144, 20);
            this.lnombre1.TabIndex = 0;
            this.lnombre1.Text = "Nombre Jugador 1:";
            // 
            // pjuego
            // 
            this.pjuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pjuego.Controls.Add(this.lnombreturno);
            this.pjuego.Controls.Add(this.lturno);
            this.pjuego.Controls.Add(this.lvidas);
            this.pjuego.Controls.Add(this.labelvidas);
            this.pjuego.Controls.Add(this.lfallos);
            this.pjuego.Controls.Add(this.laciertos);
            this.pjuego.Controls.Add(this.label3);
            this.pjuego.Controls.Add(this.label2);
            this.pjuego.Controls.Add(this.lnivel);
            this.pjuego.Controls.Add(this.label1);
            this.pjuego.Controls.Add(this.lnum2);
            this.pjuego.Controls.Add(this.bcomprobar);
            this.pjuego.Controls.Add(this.tresultado);
            this.pjuego.Controls.Add(this.lnum1);
            this.pjuego.Controls.Add(this.lop);
            this.pjuego.Location = new System.Drawing.Point(19, 219);
            this.pjuego.Name = "pjuego";
            this.pjuego.Size = new System.Drawing.Size(547, 137);
            this.pjuego.TabIndex = 2;
            this.pjuego.Visible = false;
            // 
            // lnombreturno
            // 
            this.lnombreturno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnombreturno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnombreturno.Location = new System.Drawing.Point(389, 54);
            this.lnombreturno.Name = "lnombreturno";
            this.lnombreturno.Size = new System.Drawing.Size(142, 29);
            this.lnombreturno.TabIndex = 14;
            // 
            // lturno
            // 
            this.lturno.AutoSize = true;
            this.lturno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lturno.Location = new System.Drawing.Point(430, 36);
            this.lturno.Name = "lturno";
            this.lturno.Size = new System.Drawing.Size(64, 16);
            this.lturno.TabIndex = 13;
            this.lturno.Text = "Turno de:";
            // 
            // lvidas
            // 
            this.lvidas.AutoSize = true;
            this.lvidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvidas.Location = new System.Drawing.Point(81, 101);
            this.lvidas.Name = "lvidas";
            this.lvidas.Size = new System.Drawing.Size(14, 16);
            this.lvidas.TabIndex = 12;
            this.lvidas.Text = "3";
            // 
            // labelvidas
            // 
            this.labelvidas.AutoSize = true;
            this.labelvidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvidas.Location = new System.Drawing.Point(32, 101);
            this.labelvidas.Name = "labelvidas";
            this.labelvidas.Size = new System.Drawing.Size(45, 16);
            this.labelvidas.TabIndex = 11;
            this.labelvidas.Text = "Vidas:";
            // 
            // lfallos
            // 
            this.lfallos.AutoSize = true;
            this.lfallos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfallos.Location = new System.Drawing.Point(81, 76);
            this.lfallos.Name = "lfallos";
            this.lfallos.Size = new System.Drawing.Size(14, 16);
            this.lfallos.TabIndex = 10;
            this.lfallos.Text = "0";
            // 
            // laciertos
            // 
            this.laciertos.AutoSize = true;
            this.laciertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laciertos.Location = new System.Drawing.Point(81, 52);
            this.laciertos.Name = "laciertos";
            this.laciertos.Size = new System.Drawing.Size(14, 16);
            this.laciertos.TabIndex = 9;
            this.laciertos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fallos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aciertos:";
            // 
            // lnivel
            // 
            this.lnivel.AutoSize = true;
            this.lnivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnivel.Location = new System.Drawing.Point(71, 14);
            this.lnivel.Name = "lnivel";
            this.lnivel.Size = new System.Drawing.Size(20, 24);
            this.lnivel.TabIndex = 6;
            this.lnivel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nivel:";
            // 
            // lnum2
            // 
            this.lnum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnum2.Location = new System.Drawing.Point(298, 15);
            this.lnum2.Name = "lnum2";
            this.lnum2.Size = new System.Drawing.Size(47, 23);
            this.lnum2.TabIndex = 4;
            // 
            // bcomprobar
            // 
            this.bcomprobar.Location = new System.Drawing.Point(216, 76);
            this.bcomprobar.Name = "bcomprobar";
            this.bcomprobar.Size = new System.Drawing.Size(103, 50);
            this.bcomprobar.TabIndex = 3;
            this.bcomprobar.Text = "Comprobar respuesta";
            this.bcomprobar.UseVisualStyleBackColor = true;
            // 
            // tresultado
            // 
            this.tresultado.Location = new System.Drawing.Point(219, 50);
            this.tresultado.Name = "tresultado";
            this.tresultado.Size = new System.Drawing.Size(100, 20);
            this.tresultado.TabIndex = 2;
            // 
            // lnum1
            // 
            this.lnum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnum1.Location = new System.Drawing.Point(191, 15);
            this.lnum1.Name = "lnum1";
            this.lnum1.Size = new System.Drawing.Size(47, 23);
            this.lnum1.TabIndex = 1;
            // 
            // lop
            // 
            this.lop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lop.Location = new System.Drawing.Point(247, 15);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(41, 23);
            this.lop.TabIndex = 0;
            // 
            // presultados
            // 
            this.presultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.presultados.Location = new System.Drawing.Point(19, 351);
            this.presultados.Name = "presultados";
            this.presultados.Size = new System.Drawing.Size(547, 144);
            this.presultados.TabIndex = 3;
            this.presultados.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 500);
            this.Controls.Add(this.presultados);
            this.Controls.Add(this.pjuego);
            this.Controls.Add(this.pconfiguracion);
            this.Controls.Add(this.ltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pconfiguracion.ResumeLayout(false);
            this.pconfiguracion.PerformLayout();
            this.pjuego.ResumeLayout(false);
            this.pjuego.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.Panel pconfiguracion;
        private System.Windows.Forms.TextBox tnombre1;
        private System.Windows.Forms.Label lnombre1;
        private System.Windows.Forms.Button biniciar;
        private System.Windows.Forms.Button bdosjugadores;
        private System.Windows.Forms.Button bindividual;
        private System.Windows.Forms.TextBox tnombre2;
        private System.Windows.Forms.Label lnombre2;
        private System.Windows.Forms.Panel pjuego;
        private System.Windows.Forms.Label lnum2;
        private System.Windows.Forms.Button bcomprobar;
        private System.Windows.Forms.Label lnum1;
        private System.Windows.Forms.Label lop;
        private System.Windows.Forms.Label lnivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lfallos;
        private System.Windows.Forms.Label laciertos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel presultados;
        private System.Windows.Forms.Label labelvidas;
        private System.Windows.Forms.Label lnombreturno;
        private System.Windows.Forms.Label lturno;
        private System.Windows.Forms.Label lvidas;
        private System.Windows.Forms.TextBox tresultado;
    }
}

